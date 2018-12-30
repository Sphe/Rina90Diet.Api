using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Rina90Diet.Front.ApiWeb
{
    public partial class Rina90DietdbContext : DbContext
    {
        private string _connString;

        public Rina90DietdbContext()
        {
        }

        public Rina90DietdbContext(string connString)
        {
            _connString = connString;
        }

        public Rina90DietdbContext(DbContextOptions<Rina90DietdbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Abusecommentmap> Abusecommentmap { get; set; }
        public virtual DbSet<Addresstype> Addresstype { get; set; }
        public virtual DbSet<Article> Article { get; set; }
        public virtual DbSet<Articleimagemap> Articleimagemap { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Categoryculturemap> Categoryculturemap { get; set; }
        public virtual DbSet<Categoryimagemap> Categoryimagemap { get; set; }
        public virtual DbSet<Comment> Comment { get; set; }
        public virtual DbSet<Contact> Contact { get; set; }
        public virtual DbSet<Contacttype> Contacttype { get; set; }
        public virtual DbSet<Contentblock> Contentblock { get; set; }
        public virtual DbSet<Contentblockculturemap> Contentblockculturemap { get; set; }
        public virtual DbSet<Contentblocktype> Contentblocktype { get; set; }
        public virtual DbSet<Creditcardtype> Creditcardtype { get; set; }
        public virtual DbSet<Culture> Culture { get; set; }
        public virtual DbSet<Customerprofile> Customerprofile { get; set; }
        public virtual DbSet<Customerweightentry> Customerweightentry { get; set; }
        public virtual DbSet<Genericattribute> Genericattribute { get; set; }
        public virtual DbSet<Genericattributetype> Genericattributetype { get; set; }
        public virtual DbSet<Genericattributevalue> Genericattributevalue { get; set; }
        public virtual DbSet<Image> Image { get; set; }
        public virtual DbSet<Page> Page { get; set; }
        public virtual DbSet<Pagebehavior> Pagebehavior { get; set; }
        public virtual DbSet<Pageculturemap> Pageculturemap { get; set; }
        public virtual DbSet<Pageevent> Pageevent { get; set; }
        public virtual DbSet<Pageimagemap> Pageimagemap { get; set; }
        public virtual DbSet<Pageimagetype> Pageimagetype { get; set; }
        public virtual DbSet<Pagetype> Pagetype { get; set; }
        public virtual DbSet<People> People { get; set; }
        public virtual DbSet<Phone> Phone { get; set; }
        public virtual DbSet<Phonetype> Phonetype { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Usergenericattributemap> Usergenericattributemap { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseNpgsql("Host=142.4.211.58;Database=rinadiet-0.1;Username=pgadmin;Password=glx132@");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Abusecommentmap>(entity =>
            {
                entity.HasKey(e => e.Abusecommentid);

                entity.ToTable("abusecommentmap");

                entity.HasIndex(e => e.Abusecommentid)
                    .HasName("index_abusecommentid");

                entity.Property(e => e.Abusecommentid).HasColumnName("abusecommentid");

                entity.Property(e => e.Commentid).HasColumnName("commentid");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasColumnName("createdby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Createdon)
                    .HasColumnName("createdon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-12-29'::date");

                entity.Property(e => e.Isabuse).HasColumnName("isabuse");

                entity.Property(e => e.Modifiedby)
                    .IsRequired()
                    .HasColumnName("modifiedby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Modifiedon)
                    .HasColumnName("modifiedon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-12-29'::date");

                entity.Property(e => e.Userid).HasColumnName("userid");
            });

            modelBuilder.Entity<Addresstype>(entity =>
            {
                entity.ToTable("addresstype");

                entity.Property(e => e.Addresstypeid).HasColumnName("addresstypeid");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasColumnName("createdby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Createdon)
                    .HasColumnName("createdon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-12-29'::date");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("character varying(100)");

                entity.Property(e => e.Modifiedby)
                    .IsRequired()
                    .HasColumnName("modifiedby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Modifiedon)
                    .HasColumnName("modifiedon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-12-29'::date");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("character varying(50)");
            });

            modelBuilder.Entity<Article>(entity =>
            {
                entity.ToTable("article");

                entity.Property(e => e.Articleid).HasColumnName("articleid");

                entity.Property(e => e.Activate).HasColumnName("activate");

                entity.Property(e => e.Body).HasColumnName("body");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasColumnName("createdby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Createdon)
                    .HasColumnName("createdon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-12-29'::date");

                entity.Property(e => e.Cultureid).HasColumnName("cultureid");

                entity.Property(e => e.Ishtml).HasColumnName("ishtml");

                entity.Property(e => e.Keywords)
                    .HasColumnName("keywords")
                    .HasColumnType("character varying(255)");

                entity.Property(e => e.Metadescription)
                    .HasColumnName("metadescription")
                    .HasColumnType("character varying(255)");

                entity.Property(e => e.Metakeyword)
                    .HasColumnName("metakeyword")
                    .HasColumnType("character varying(255)");

                entity.Property(e => e.Metatitle)
                    .HasColumnName("metatitle")
                    .HasColumnType("character varying(255)");

                entity.Property(e => e.Modifiedby)
                    .IsRequired()
                    .HasColumnName("modifiedby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Modifiedon)
                    .HasColumnName("modifiedon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-12-29'::date");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title")
                    .HasColumnType("character varying(100)");

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.HasOne(d => d.Culture)
                    .WithMany(p => p.Article)
                    .HasForeignKey(d => d.Cultureid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_article_culture");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Article)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_article_user");
            });

            modelBuilder.Entity<Articleimagemap>(entity =>
            {
                entity.HasKey(e => e.Articleimageid);

                entity.ToTable("articleimagemap");

                entity.Property(e => e.Articleimageid).HasColumnName("articleimageid");

                entity.Property(e => e.Activate).HasColumnName("activate");

                entity.Property(e => e.Articleid).HasColumnName("articleid");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasColumnName("createdby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Createdon)
                    .HasColumnName("createdon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-12-29'::date");

                entity.Property(e => e.Imageid).HasColumnName("imageid");

                entity.Property(e => e.Modifiedby)
                    .IsRequired()
                    .HasColumnName("modifiedby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Modifiedon)
                    .HasColumnName("modifiedon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-12-29'::date");

                entity.HasOne(d => d.Article)
                    .WithMany(p => p.Articleimagemap)
                    .HasForeignKey(d => d.Articleid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_articleimagemap_article");

                entity.HasOne(d => d.Image)
                    .WithMany(p => p.Articleimagemap)
                    .HasForeignKey(d => d.Imageid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_articleimagemap_image");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("category");

                entity.Property(e => e.Categoryid).HasColumnName("categoryid");

                entity.Property(e => e.Activate).HasColumnName("activate");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasColumnName("createdby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Createdon)
                    .HasColumnName("createdon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-12-29'::date");

                entity.Property(e => e.Isdefault).HasColumnName("isdefault");

                entity.Property(e => e.Modifiedby)
                    .IsRequired()
                    .HasColumnName("modifiedby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Modifiedon)
                    .HasColumnName("modifiedon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-12-29'::date");

                entity.Property(e => e.Parentid).HasColumnName("parentid");

                entity.Property(e => e.Sort).HasColumnName("sort");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.Parentid)
                    .HasConstraintName("fk_childrencategory_category");
            });

            modelBuilder.Entity<Categoryculturemap>(entity =>
            {
                entity.HasKey(e => e.Categorycultureid);

                entity.ToTable("categoryculturemap");

                entity.Property(e => e.Categorycultureid).HasColumnName("categorycultureid");

                entity.Property(e => e.Categoryalternativename)
                    .HasColumnName("categoryalternativename")
                    .HasColumnType("character varying(150)");

                entity.Property(e => e.Categoryid).HasColumnName("categoryid");

                entity.Property(e => e.Categoryname)
                    .IsRequired()
                    .HasColumnName("categoryname")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasColumnName("createdby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Createdon)
                    .HasColumnName("createdon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-12-29'::date");

                entity.Property(e => e.Cultureid).HasColumnName("cultureid");

                entity.Property(e => e.Metadescription)
                    .HasColumnName("metadescription")
                    .HasColumnType("character varying(255)");

                entity.Property(e => e.Metakeyword)
                    .HasColumnName("metakeyword")
                    .HasColumnType("character varying(255)");

                entity.Property(e => e.Metatitle)
                    .HasColumnName("metatitle")
                    .HasColumnType("character varying(255)");

                entity.Property(e => e.Modifiedby)
                    .IsRequired()
                    .HasColumnName("modifiedby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Modifiedon)
                    .HasColumnName("modifiedon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-12-29'::date");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Categoryculturemap)
                    .HasForeignKey(d => d.Categoryid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_categoryculturemap_category");

                entity.HasOne(d => d.Culture)
                    .WithMany(p => p.Categoryculturemap)
                    .HasForeignKey(d => d.Cultureid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_categoryculturemap_culture");
            });

            modelBuilder.Entity<Categoryimagemap>(entity =>
            {
                entity.HasKey(e => e.Categoryimageid);

                entity.ToTable("categoryimagemap");

                entity.Property(e => e.Categoryimageid).HasColumnName("categoryimageid");

                entity.Property(e => e.Activate).HasColumnName("activate");

                entity.Property(e => e.Categoryid).HasColumnName("categoryid");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasColumnName("createdby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Createdon)
                    .HasColumnName("createdon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-12-29'::date");

                entity.Property(e => e.Imageid).HasColumnName("imageid");

                entity.Property(e => e.Modifiedby)
                    .IsRequired()
                    .HasColumnName("modifiedby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Modifiedon)
                    .HasColumnName("modifiedon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-12-29'::date");

                entity.Property(e => e.Sort).HasColumnName("sort");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Categoryimagemap)
                    .HasForeignKey(d => d.Categoryid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_categoryimagemap_category");

                entity.HasOne(d => d.Image)
                    .WithMany(p => p.Categoryimagemap)
                    .HasForeignKey(d => d.Imageid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_categoryimagemap_image");
            });

            modelBuilder.Entity<Comment>(entity =>
            {
                entity.ToTable("comment");

                entity.Property(e => e.Commentid).HasColumnName("commentid");

                entity.Property(e => e.Activate).HasColumnName("activate");

                entity.Property(e => e.Articleid).HasColumnName("articleid");

                entity.Property(e => e.Body).HasColumnName("body");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasColumnName("createdby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Createdon)
                    .HasColumnName("createdon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-12-29'::date");

                entity.Property(e => e.Modifiedby)
                    .IsRequired()
                    .HasColumnName("modifiedby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Modifiedon)
                    .HasColumnName("modifiedon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-12-29'::date");

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.HasOne(d => d.Article)
                    .WithMany(p => p.Comment)
                    .HasForeignKey(d => d.Articleid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_comment_article");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.CommentNavigation)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_comment_user");
            });

            modelBuilder.Entity<Contact>(entity =>
            {
                entity.ToTable("contact");

                entity.Property(e => e.Contactid).HasColumnName("contactid");

                entity.Property(e => e.Contacttypeid).HasColumnName("contacttypeid");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasColumnName("createdby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Createdon)
                    .HasColumnName("createdon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-12-29'::date");

                entity.Property(e => e.Modifiedby)
                    .IsRequired()
                    .HasColumnName("modifiedby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Modifiedon)
                    .HasColumnName("modifiedon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-12-29'::date");

                entity.Property(e => e.Peopleid).HasColumnName("peopleid");

                entity.HasOne(d => d.Contacttype)
                    .WithMany(p => p.Contact)
                    .HasForeignKey(d => d.Contacttypeid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_contact_contacttype");

                entity.HasOne(d => d.People)
                    .WithMany(p => p.Contact)
                    .HasForeignKey(d => d.Peopleid)
                    .HasConstraintName("fk_contact_people");
            });

            modelBuilder.Entity<Contacttype>(entity =>
            {
                entity.ToTable("contacttype");

                entity.Property(e => e.Contacttypeid).HasColumnName("contacttypeid");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasColumnName("createdby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Createdon)
                    .HasColumnName("createdon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-12-29'::date");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("character varying(255)");

                entity.Property(e => e.Modifiedby)
                    .IsRequired()
                    .HasColumnName("modifiedby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Modifiedon)
                    .HasColumnName("modifiedon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-12-29'::date");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("character varying(50)");
            });

            modelBuilder.Entity<Contentblock>(entity =>
            {
                entity.ToTable("contentblock");

                entity.Property(e => e.Contentblockid).HasColumnName("contentblockid");

                entity.Property(e => e.Activate).HasColumnName("activate");

                entity.Property(e => e.Contentblocktypeid).HasColumnName("contentblocktypeid");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasColumnName("createdby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Createdon)
                    .HasColumnName("createdon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-12-29'::date");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("character varying(255)");

                entity.Property(e => e.Modifiedby)
                    .IsRequired()
                    .HasColumnName("modifiedby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Modifiedon)
                    .HasColumnName("modifiedon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-12-29'::date");

                entity.Property(e => e.Pageid).HasColumnName("pageid");

                entity.Property(e => e.Sort).HasColumnName("sort");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title")
                    .HasColumnType("character varying(100)");

                entity.HasOne(d => d.Contentblocktype)
                    .WithMany(p => p.Contentblock)
                    .HasForeignKey(d => d.Contentblocktypeid)
                    .HasConstraintName("fk_cb_cbtype");

                entity.HasOne(d => d.Page)
                    .WithMany(p => p.Contentblock)
                    .HasForeignKey(d => d.Pageid)
                    .HasConstraintName("fk_contentblock_page");
            });

            modelBuilder.Entity<Contentblockculturemap>(entity =>
            {
                entity.ToTable("contentblockculturemap");

                entity.Property(e => e.Contentblockculturemapid).HasColumnName("contentblockculturemapid");

                entity.Property(e => e.Activate).HasColumnName("activate");

                entity.Property(e => e.Content).HasColumnName("content");

                entity.Property(e => e.Contentblockid).HasColumnName("contentblockid");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasColumnName("createdby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Createdon)
                    .HasColumnName("createdon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-12-29'::date");

                entity.Property(e => e.Cultureid).HasColumnName("cultureid");

                entity.Property(e => e.Modifiedby)
                    .IsRequired()
                    .HasColumnName("modifiedby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Modifiedon)
                    .HasColumnName("modifiedon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-12-29'::date");

                entity.HasOne(d => d.Contentblock)
                    .WithMany(p => p.Contentblockculturemap)
                    .HasForeignKey(d => d.Contentblockid)
                    .HasConstraintName("fk_cbcm_cblock");

                entity.HasOne(d => d.Culture)
                    .WithMany(p => p.Contentblockculturemap)
                    .HasForeignKey(d => d.Cultureid)
                    .HasConstraintName("fk_cbcm_culture");
            });

            modelBuilder.Entity<Contentblocktype>(entity =>
            {
                entity.ToTable("contentblocktype");

                entity.Property(e => e.Contentblocktypeid).HasColumnName("contentblocktypeid");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasColumnName("createdby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Createdon)
                    .HasColumnName("createdon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-12-29'::date");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("character varying(255)");

                entity.Property(e => e.Modifiedby)
                    .IsRequired()
                    .HasColumnName("modifiedby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Modifiedon)
                    .HasColumnName("modifiedon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-12-29'::date");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasColumnType("character varying(100)");
            });

            modelBuilder.Entity<Creditcardtype>(entity =>
            {
                entity.ToTable("creditcardtype");

                entity.Property(e => e.Creditcardtypeid).HasColumnName("creditcardtypeid");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasColumnName("createdby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Createdon)
                    .HasColumnName("createdon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-12-29'::date");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("character varying(100)");

                entity.Property(e => e.Modifiedby)
                    .IsRequired()
                    .HasColumnName("modifiedby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Modifiedon)
                    .HasColumnName("modifiedon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-12-29'::date");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("character varying(50)");
            });

            modelBuilder.Entity<Culture>(entity =>
            {
                entity.ToTable("culture");

                entity.Property(e => e.Cultureid).HasColumnName("cultureid");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasColumnName("createdby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Createdon)
                    .HasColumnName("createdon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-12-29'::date");

                entity.Property(e => e.Defaultcurrencycode)
                    .HasColumnName("defaultcurrencycode")
                    .HasColumnType("character(3)");

                entity.Property(e => e.Defaultsizecode)
                    .HasColumnName("defaultsizecode")
                    .HasColumnType("character varying(10)");

                entity.Property(e => e.Defaultsizeunit)
                    .HasColumnName("defaultsizeunit")
                    .HasColumnType("character varying(10)");

                entity.Property(e => e.Defaultweightcode)
                    .HasColumnName("defaultweightcode")
                    .HasColumnType("character varying(10)");

                entity.Property(e => e.Defaultweightunit)
                    .HasColumnName("defaultweightunit")
                    .HasColumnType("character varying(10)");

                entity.Property(e => e.Languagecode)
                    .IsRequired()
                    .HasColumnName("languagecode")
                    .HasColumnType("character(2)");

                entity.Property(e => e.Locale)
                    .HasColumnName("locale")
                    .HasColumnType("character(5)");

                entity.Property(e => e.Modifiedby)
                    .IsRequired()
                    .HasColumnName("modifiedby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Modifiedon)
                    .HasColumnName("modifiedon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-12-29'::date");
            });

            modelBuilder.Entity<Customerprofile>(entity =>
            {
                entity.ToTable("customerprofile");

                entity.HasIndex(e => e.Customerprofileid)
                    .HasName("idx_customerprofile");

                entity.Property(e => e.Customerprofileid).HasColumnName("customerprofileid");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasColumnName("createdby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Createdon)
                    .HasColumnName("createdon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-12-29'::date");

                entity.Property(e => e.Currentimc)
                    .HasColumnName("currentimc")
                    .HasColumnType("numeric(12,4)");

                entity.Property(e => e.Currentweight)
                    .HasColumnName("currentweight")
                    .HasColumnType("numeric(12,4)");

                entity.Property(e => e.Enddate)
                    .HasColumnName("enddate")
                    .HasColumnType("date");

                entity.Property(e => e.Heightinm)
                    .HasColumnName("heightinm")
                    .HasColumnType("numeric(12,4)");

                entity.Property(e => e.Initialimc)
                    .HasColumnName("initialimc")
                    .HasColumnType("numeric(12,4)");

                entity.Property(e => e.Initialweight)
                    .HasColumnName("initialweight")
                    .HasColumnType("numeric(12,4)");

                entity.Property(e => e.Modifiedby)
                    .IsRequired()
                    .HasColumnName("modifiedby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Modifiedon)
                    .HasColumnName("modifiedon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-12-29'::date");

                entity.Property(e => e.Numberdietdays).HasColumnName("numberdietdays");

                entity.Property(e => e.Iswaterday)
                    .HasColumnName("iswaterday");

                entity.Property(e => e.Startdate)
                    .HasColumnName("startdate")
                    .HasColumnType("date");

                entity.Property(e => e.Targetimc)
                    .HasColumnName("targetimc")
                    .HasColumnType("numeric(12,4)");

                entity.Property(e => e.Targetweight)
                    .HasColumnName("targetweight")
                    .HasColumnType("numeric(12,4)");

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Customerprofile)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_customerprofile_1");
            });

            modelBuilder.Entity<Customerweightentry>(entity =>
            {
                entity.ToTable("customerweightentry");

                entity.HasIndex(e => e.Customerweightentryid)
                    .HasName("idx_customerweightentry");

                entity.Property(e => e.Customerweightentryid).HasColumnName("customerweightentryid");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasColumnName("createdby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Createdon)
                    .HasColumnName("createdon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-12-29'::date");

                entity.Property(e => e.Customerprofileid).HasColumnName("customerprofileid");

                entity.Property(e => e.Timestamp).HasColumnName("timestamp").HasColumnType("date");

                entity.Property(e => e.Modifiedby)
                    .IsRequired()
                    .HasColumnName("modifiedby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Modifiedon)
                    .HasColumnName("modifiedon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-12-29'::date");

                entity.Property(e => e.Indexday).HasColumnName("indexday");

                entity.Property(e => e.Weightinkg)
                    .HasColumnName("weightinkg")
                    .HasColumnType("numeric(12,4)");

                entity.HasOne(d => d.Customerprofile)
                    .WithMany(p => p.Customerweightentry)
                    .HasForeignKey(d => d.Customerprofileid)
                    .HasConstraintName("fk_customerprofile_1");
            });

            modelBuilder.Entity<Genericattribute>(entity =>
            {
                entity.ToTable("genericattribute");

                entity.Property(e => e.Genericattributeid).HasColumnName("genericattributeid");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasColumnName("createdby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Createdon)
                    .HasColumnName("createdon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-12-29'::date");

                entity.Property(e => e.Genericattributetypeid).HasColumnName("genericattributetypeid");

                entity.Property(e => e.Genericattributevalueid).HasColumnName("genericattributevalueid");

                entity.Property(e => e.Modifiedby)
                    .IsRequired()
                    .HasColumnName("modifiedby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Modifiedon)
                    .HasColumnName("modifiedon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-12-29'::date");

                entity.Property(e => e.Typelabelstring).HasColumnName("typelabelstring");

                entity.Property(e => e.Typestring)
                    .HasColumnName("typestring")
                    .HasColumnType("character varying(512)");

                entity.Property(e => e.Valuelabelstring).HasColumnName("valuelabelstring");

                entity.Property(e => e.Valuestring).HasColumnName("valuestring");

                entity.HasOne(d => d.Genericattributetype)
                    .WithMany(p => p.Genericattribute)
                    .HasForeignKey(d => d.Genericattributetypeid)
                    .HasConstraintName("fk_generica_fk_generi_generica");

                entity.HasOne(d => d.Genericattributevalue)
                    .WithMany(p => p.Genericattribute)
                    .HasForeignKey(d => d.Genericattributevalueid)
                    .HasConstraintName("fk_genericattribute_value");
            });

            modelBuilder.Entity<Genericattributetype>(entity =>
            {
                entity.ToTable("genericattributetype");

                entity.Property(e => e.Genericattributetypeid).HasColumnName("genericattributetypeid");

                entity.Property(e => e.Categoryid).HasColumnName("categoryid");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasColumnName("createdby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Createdon)
                    .HasColumnName("createdon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-12-29'::date");

                entity.Property(e => e.Metatypelabel).HasColumnName("metatypelabel");

                entity.Property(e => e.Metatypestring)
                    .HasColumnName("metatypestring")
                    .HasColumnType("character varying(512)");

                entity.Property(e => e.Modifiedby)
                    .IsRequired()
                    .HasColumnName("modifiedby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Modifiedon)
                    .HasColumnName("modifiedon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-12-29'::date");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.Sort).HasColumnName("sort");

                entity.Property(e => e.Valuebool).HasColumnName("valuebool");

                entity.Property(e => e.Valuedate)
                    .HasColumnName("valuedate")
                    .HasColumnType("date");

                entity.Property(e => e.Valuelabelbool).HasColumnName("valuelabelbool");

                entity.Property(e => e.Valuelabeldate)
                    .HasColumnName("valuelabeldate")
                    .HasColumnType("date");

                entity.Property(e => e.Valuelabelnumber)
                    .HasColumnName("valuelabelnumber")
                    .HasColumnType("numeric(12,4)");

                entity.Property(e => e.Valuelabelstring).HasColumnName("valuelabelstring");

                entity.Property(e => e.Valuenumber)
                    .HasColumnName("valuenumber")
                    .HasColumnType("numeric(12,4)");

                entity.Property(e => e.Valuestring).HasColumnName("valuestring");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Genericattributetype)
                    .HasForeignKey(d => d.Categoryid)
                    .HasConstraintName("fk_generica_reference_category");
            });

            modelBuilder.Entity<Genericattributevalue>(entity =>
            {
                entity.ToTable("genericattributevalue");

                entity.Property(e => e.Genericattributevalueid).HasColumnName("genericattributevalueid");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasColumnName("createdby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Createdon)
                    .HasColumnName("createdon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-12-29'::date");

                entity.Property(e => e.Label)
                    .HasColumnName("label")
                    .HasColumnType("character varying(150)");

                entity.Property(e => e.Metatypelabel).HasColumnName("metatypelabel");

                entity.Property(e => e.Metatypestring)
                    .HasColumnName("metatypestring")
                    .HasColumnType("character varying(512)");

                entity.Property(e => e.Modifiedby)
                    .IsRequired()
                    .HasColumnName("modifiedby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Modifiedon)
                    .HasColumnName("modifiedon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-12-29'::date");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.Sort).HasColumnName("sort");

                entity.Property(e => e.Valuebool).HasColumnName("valuebool");

                entity.Property(e => e.Valuedate)
                    .HasColumnName("valuedate")
                    .HasColumnType("date");

                entity.Property(e => e.Valuelabelbool).HasColumnName("valuelabelbool");

                entity.Property(e => e.Valuelabeldate)
                    .HasColumnName("valuelabeldate")
                    .HasColumnType("date");

                entity.Property(e => e.Valuelabelnumber)
                    .HasColumnName("valuelabelnumber")
                    .HasColumnType("numeric(12,4)");

                entity.Property(e => e.Valuelabelstring).HasColumnName("valuelabelstring");

                entity.Property(e => e.Valuenumber)
                    .HasColumnName("valuenumber")
                    .HasColumnType("numeric(12,4)");

                entity.Property(e => e.Valuestring).HasColumnName("valuestring");
            });

            modelBuilder.Entity<Image>(entity =>
            {
                entity.ToTable("image");

                entity.Property(e => e.Imageid).HasColumnName("imageid");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasColumnName("createdby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Createdon)
                    .HasColumnName("createdon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-12-29'::date");

                entity.Property(e => e.Fullimageurl)
                    .IsRequired()
                    .HasColumnName("fullimageurl")
                    .HasColumnType("character varying(255)");

                entity.Property(e => e.Modifiedby)
                    .IsRequired()
                    .HasColumnName("modifiedby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Modifiedon)
                    .HasColumnName("modifiedon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-12-29'::date");

                entity.Property(e => e.Thumburl)
                    .HasColumnName("thumburl")
                    .HasColumnType("character varying(255)");
            });

            modelBuilder.Entity<Page>(entity =>
            {
                entity.ToTable("page");

                entity.Property(e => e.Pageid).HasColumnName("pageid");

                entity.Property(e => e.Action)
                    .HasColumnName("action")
                    .HasColumnType("character varying(255)");

                entity.Property(e => e.Activate).HasColumnName("activate");

                entity.Property(e => e.Categoryid).HasColumnName("categoryid");

                entity.Property(e => e.Controller)
                    .HasColumnName("controller")
                    .HasColumnType("character varying(255)");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasColumnName("createdby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Createdon)
                    .HasColumnName("createdon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-12-29'::date");

                entity.Property(e => e.Isdefault).HasColumnName("isdefault");

                entity.Property(e => e.Modifiedby)
                    .IsRequired()
                    .HasColumnName("modifiedby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Modifiedon)
                    .HasColumnName("modifiedon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-12-29'::date");

                entity.Property(e => e.Pagetypeid).HasColumnName("pagetypeid");

                entity.Property(e => e.Parentpageid).HasColumnName("parentpageid");

                entity.Property(e => e.Sort).HasColumnName("sort");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title")
                    .HasColumnType("character varying(100)");

                entity.Property(e => e.Url)
                    .HasColumnName("url")
                    .HasColumnType("character varying(100)");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Page)
                    .HasForeignKey(d => d.Categoryid)
                    .HasConstraintName("fk_page_category");

                entity.HasOne(d => d.Pagetype)
                    .WithMany(p => p.Page)
                    .HasForeignKey(d => d.Pagetypeid)
                    .HasConstraintName("fk_page_pagetype");

                entity.HasOne(d => d.Parentpage)
                    .WithMany(p => p.InverseParentpage)
                    .HasForeignKey(d => d.Parentpageid)
                    .HasConstraintName("fk_childrenpage_page");
            });

            modelBuilder.Entity<Pagebehavior>(entity =>
            {
                entity.ToTable("pagebehavior");

                entity.Property(e => e.Pagebehaviorid).HasColumnName("pagebehaviorid");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasColumnName("createdby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Createdon)
                    .HasColumnName("createdon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-12-29'::date");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.Modifiedby)
                    .IsRequired()
                    .HasColumnName("modifiedby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Modifiedon)
                    .HasColumnName("modifiedon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-12-29'::date");
            });

            modelBuilder.Entity<Pageculturemap>(entity =>
            {
                entity.ToTable("pageculturemap");

                entity.Property(e => e.Pageculturemapid).HasColumnName("pageculturemapid");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasColumnName("createdby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Createdon)
                    .HasColumnName("createdon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-12-29'::date");

                entity.Property(e => e.Cultureid).HasColumnName("cultureid");

                entity.Property(e => e.Keywords)
                    .HasColumnName("keywords")
                    .HasColumnType("character varying(255)");

                entity.Property(e => e.Metadescription)
                    .HasColumnName("metadescription")
                    .HasColumnType("character varying(255)");

                entity.Property(e => e.Metakeyword)
                    .HasColumnName("metakeyword")
                    .HasColumnType("character varying(255)");

                entity.Property(e => e.Metatitle)
                    .HasColumnName("metatitle")
                    .HasColumnType("character varying(255)");

                entity.Property(e => e.Modifiedby)
                    .IsRequired()
                    .HasColumnName("modifiedby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Modifiedon)
                    .HasColumnName("modifiedon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-12-29'::date");

                entity.Property(e => e.Pageid).HasColumnName("pageid");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title")
                    .HasColumnType("character varying(100)");

                entity.HasOne(d => d.Culture)
                    .WithMany(p => p.Pageculturemap)
                    .HasForeignKey(d => d.Cultureid)
                    .HasConstraintName("fk_pageculturemap_culture");

                entity.HasOne(d => d.Page)
                    .WithMany(p => p.Pageculturemap)
                    .HasForeignKey(d => d.Pageid)
                    .HasConstraintName("fk_pageculturemap_page");
            });

            modelBuilder.Entity<Pageevent>(entity =>
            {
                entity.ToTable("pageevent");

                entity.Property(e => e.Pageeventid).HasColumnName("pageeventid");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasColumnName("createdby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Createdon)
                    .HasColumnName("createdon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-12-29'::date");

                entity.Property(e => e.Eventdate)
                    .HasColumnName("eventdate")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-12-29'::date");

                entity.Property(e => e.Ip)
                    .IsRequired()
                    .HasColumnName("ip")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.Modifiedby)
                    .IsRequired()
                    .HasColumnName("modifiedby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Modifiedon)
                    .HasColumnName("modifiedon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-12-29'::date");

                entity.Property(e => e.Pagebehaviorid).HasColumnName("pagebehaviorid");

                entity.Property(e => e.Pageculturemapid).HasColumnName("pageculturemapid");

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.HasOne(d => d.Pagebehavior)
                    .WithMany(p => p.Pageevent)
                    .HasForeignKey(d => d.Pagebehaviorid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_pageevent_pagebehavior");

                entity.HasOne(d => d.Pageculturemap)
                    .WithMany(p => p.Pageevent)
                    .HasForeignKey(d => d.Pageculturemapid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_pageevent_pageculturemap");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Pageevent)
                    .HasForeignKey(d => d.Userid)
                    .HasConstraintName("fk_pageevent_user");
            });

            modelBuilder.Entity<Pageimagemap>(entity =>
            {
                entity.HasKey(e => e.Pageimageid);

                entity.ToTable("pageimagemap");

                entity.Property(e => e.Pageimageid).HasColumnName("pageimageid");

                entity.Property(e => e.Activate).HasColumnName("activate");

                entity.Property(e => e.Alt)
                    .HasColumnName("alt")
                    .HasColumnType("character varying(100)");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasColumnName("createdby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Createdon)
                    .HasColumnName("createdon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-12-29'::date");

                entity.Property(e => e.Imageid).HasColumnName("imageid");

                entity.Property(e => e.Modifiedby)
                    .IsRequired()
                    .HasColumnName("modifiedby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Modifiedon)
                    .HasColumnName("modifiedon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-12-29'::date");

                entity.Property(e => e.Pageid).HasColumnName("pageid");

                entity.Property(e => e.Pageimagetypeid).HasColumnName("pageimagetypeid");

                entity.Property(e => e.Sort)
                    .HasColumnName("sort")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.Image)
                    .WithMany(p => p.Pageimagemap)
                    .HasForeignKey(d => d.Imageid)
                    .HasConstraintName("fk_pageimagemap_image");

                entity.HasOne(d => d.Page)
                    .WithMany(p => p.Pageimagemap)
                    .HasForeignKey(d => d.Pageid)
                    .HasConstraintName("fk_pageimagemap_page");

                entity.HasOne(d => d.Pageimagetype)
                    .WithMany(p => p.Pageimagemap)
                    .HasForeignKey(d => d.Pageimagetypeid)
                    .HasConstraintName("fk_pageimagemap_pageimagetype");
            });

            modelBuilder.Entity<Pageimagetype>(entity =>
            {
                entity.ToTable("pageimagetype");

                entity.Property(e => e.Pageimagetypeid).HasColumnName("pageimagetypeid");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasColumnName("createdby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Createdon)
                    .HasColumnName("createdon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-12-29'::date");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("character varying(255)");

                entity.Property(e => e.Modifiedby)
                    .IsRequired()
                    .HasColumnName("modifiedby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Modifiedon)
                    .HasColumnName("modifiedon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-12-29'::date");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasColumnType("character varying(100)");
            });

            modelBuilder.Entity<Pagetype>(entity =>
            {
                entity.ToTable("pagetype");

                entity.Property(e => e.Pagetypeid).HasColumnName("pagetypeid");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasColumnName("createdby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Createdon)
                    .HasColumnName("createdon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-12-29'::date");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("character varying(255)");

                entity.Property(e => e.Modifiedby)
                    .IsRequired()
                    .HasColumnName("modifiedby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Modifiedon)
                    .HasColumnName("modifiedon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-12-29'::date");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasColumnType("character varying(100)");
            });

            modelBuilder.Entity<People>(entity =>
            {
                entity.ToTable("people");

                entity.Property(e => e.Peopleid).HasColumnName("peopleid");

                entity.Property(e => e.Company)
                    .HasColumnName("company")
                    .HasColumnType("character varying(255)");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasColumnName("createdby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Createdon)
                    .HasColumnName("createdon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-12-29'::date");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasColumnType("character varying(255)");

                entity.Property(e => e.Firstname)
                    .IsRequired()
                    .HasColumnName("firstname")
                    .HasColumnType("character varying(100)");

                entity.Property(e => e.Lastip)
                    .HasColumnName("lastip")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.Lastname)
                    .IsRequired()
                    .HasColumnName("lastname")
                    .HasColumnType("character varying(100)");

                entity.Property(e => e.Middlename)
                    .HasColumnName("middlename")
                    .HasColumnType("character varying(100)");

                entity.Property(e => e.Modifiedby)
                    .IsRequired()
                    .HasColumnName("modifiedby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Modifiedon)
                    .HasColumnName("modifiedon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-12-29'::date");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasColumnType("character varying(255)");
            });

            modelBuilder.Entity<Phone>(entity =>
            {
                entity.ToTable("phone");

                entity.Property(e => e.Phoneid).HasColumnName("phoneid");

                entity.Property(e => e.Cell)
                    .HasColumnName("cell")
                    .HasColumnType("character varying(255)");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasColumnName("createdby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Createdon)
                    .HasColumnName("createdon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-12-29'::date");

                entity.Property(e => e.Fax)
                    .HasColumnName("fax")
                    .HasColumnType("character varying(255)");

                entity.Property(e => e.Modifiedby)
                    .IsRequired()
                    .HasColumnName("modifiedby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Modifiedon)
                    .HasColumnName("modifiedon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-12-29'::date");

                entity.Property(e => e.Note)
                    .HasColumnName("note")
                    .HasColumnType("character varying(255)");

                entity.Property(e => e.Peopleid).HasColumnName("peopleid");

                entity.Property(e => e.Phone1)
                    .IsRequired()
                    .HasColumnName("phone")
                    .HasColumnType("character varying(255)");

                entity.Property(e => e.Phonetypeid).HasColumnName("phonetypeid");

                entity.HasOne(d => d.People)
                    .WithMany(p => p.Phone)
                    .HasForeignKey(d => d.Peopleid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_phone_people");

                entity.HasOne(d => d.Phonetype)
                    .WithMany(p => p.Phone)
                    .HasForeignKey(d => d.Phonetypeid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_phone_phonetype");
            });

            modelBuilder.Entity<Phonetype>(entity =>
            {
                entity.ToTable("phonetype");

                entity.HasIndex(e => e.Phonetypeid)
                    .HasName("index_phonetypeid");

                entity.Property(e => e.Phonetypeid).HasColumnName("phonetypeid");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasColumnName("createdby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Createdon)
                    .HasColumnName("createdon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-12-29'::date");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("character varying(100)");

                entity.Property(e => e.Modifiedby)
                    .IsRequired()
                    .HasColumnName("modifiedby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Modifiedon)
                    .HasColumnName("modifiedon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-12-29'::date");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("character varying(50)");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("user");

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.Property(e => e.Activate).HasColumnName("activate");

                entity.Property(e => e.Comment).HasColumnName("comment");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasColumnName("createdby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Createdon)
                    .HasColumnName("createdon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-12-29'::date");

                entity.Property(e => e.Cultureid).HasColumnName("cultureid");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasColumnType("character varying(255)");

                entity.Property(e => e.Encryptionid).HasColumnName("encryptionid");

                entity.Property(e => e.Failedanswercount).HasColumnName("failedanswercount");

                entity.Property(e => e.Failedlogincount)
                    .HasColumnName("failedlogincount")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Lastactivitydate)
                    .HasColumnName("lastactivitydate")
                    .HasColumnType("date");

                entity.Property(e => e.Lastlockoutdate)
                    .HasColumnName("lastlockoutdate")
                    .HasColumnType("date");

                entity.Property(e => e.Lastlogindate)
                    .HasColumnName("lastlogindate")
                    .HasColumnType("date");

                entity.Property(e => e.Lastpasswordchangeddate)
                    .HasColumnName("lastpasswordchangeddate")
                    .HasColumnType("date");

                entity.Property(e => e.Locked)
                    .HasColumnName("locked")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Lockeduntil)
                    .HasColumnName("lockeduntil")
                    .HasColumnType("date");

                entity.Property(e => e.Modifiedby)
                    .IsRequired()
                    .HasColumnName("modifiedby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Modifiedon)
                    .HasColumnName("modifiedon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-12-29'::date");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.Passwordanswer).HasColumnName("passwordanswer");

                entity.Property(e => e.Passwordhint).HasColumnName("passwordhint");

                entity.Property(e => e.Peopleid).HasColumnName("peopleid");

                entity.Property(e => e.Personalreference)
                    .HasColumnName("personalreference")
                    .HasColumnType("character varying(255)");

                entity.Property(e => e.Taxexempt).HasColumnName("taxexempt");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("username")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.Userverificationstatusid).HasColumnName("userverificationstatusid");

                entity.HasOne(d => d.Culture)
                    .WithMany(p => p.User)
                    .HasForeignKey(d => d.Cultureid)
                    .HasConstraintName("fk_user_culture");

                entity.HasOne(d => d.People)
                    .WithMany(p => p.User)
                    .HasForeignKey(d => d.Peopleid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_user_people");
            });

            modelBuilder.Entity<Usergenericattributemap>(entity =>
            {
                entity.HasKey(e => e.Userattributeid);

                entity.ToTable("usergenericattributemap");

                entity.Property(e => e.Userattributeid).HasColumnName("userattributeid");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasColumnName("createdby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Createdon)
                    .HasColumnName("createdon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-12-29'::date");

                entity.Property(e => e.Genericattributeid).HasColumnName("genericattributeid");

                entity.Property(e => e.Modifiedby)
                    .IsRequired()
                    .HasColumnName("modifiedby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Modifiedon)
                    .HasColumnName("modifiedon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-12-29'::date");

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.HasOne(d => d.Genericattribute)
                    .WithMany(p => p.Usergenericattributemap)
                    .HasForeignKey(d => d.Genericattributeid)
                    .HasConstraintName("fk_usergene_reference_generica");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Usergenericattributemap)
                    .HasForeignKey(d => d.Userid)
                    .HasConstraintName("fk_usergene_reference_user");
            });
        }
    }
}
