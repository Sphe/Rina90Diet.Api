using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Rina90Diet.Model.FullDomain
{
    public partial class Rina90DietdbContext : DbContext
    {
        private string _connString;

        public Rina90DietdbContext()
        {
        }

        public Rina90DietdbContext(string conn)
        {
            _connString = conn;
        }

        public Rina90DietdbContext(DbContextOptions<Rina90DietdbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Abusecommentmap> Abusecommentmap { get; set; }
        public virtual DbSet<Accountmailqueue> Accountmailqueue { get; set; }
        public virtual DbSet<Addresstype> Addresstype { get; set; }
        public virtual DbSet<Allowanceentrysheet> Allowanceentrysheet { get; set; }
        public virtual DbSet<Allowancesheet> Allowancesheet { get; set; }
        public virtual DbSet<Article> Article { get; set; }
        public virtual DbSet<Articleimagemap> Articleimagemap { get; set; }
        public virtual DbSet<Balancesheet> Balancesheet { get; set; }
        public virtual DbSet<Bankaccountverificationstatus> Bankaccountverificationstatus { get; set; }
        public virtual DbSet<Bankdetail> Bankdetail { get; set; }
        public virtual DbSet<Blockchainentity> Blockchainentity { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Categoryculturemap> Categoryculturemap { get; set; }
        public virtual DbSet<Categoryimagemap> Categoryimagemap { get; set; }
        public virtual DbSet<Coin> Coin { get; set; }
        public virtual DbSet<Coingenericattributemap> Coingenericattributemap { get; set; }
        public virtual DbSet<Coinledger> Coinledger { get; set; }
        public virtual DbSet<Coinledgercoinwalletmap> Coinledgercoinwalletmap { get; set; }
        public virtual DbSet<Coinwallet> Coinwallet { get; set; }
        public virtual DbSet<Comment> Comment { get; set; }
        public virtual DbSet<Contact> Contact { get; set; }
        public virtual DbSet<Contacttype> Contacttype { get; set; }
        public virtual DbSet<Contentblock> Contentblock { get; set; }
        public virtual DbSet<Contentblockculturemap> Contentblockculturemap { get; set; }
        public virtual DbSet<Contentblocktype> Contentblocktype { get; set; }
        public virtual DbSet<Creditcardtype> Creditcardtype { get; set; }
        public virtual DbSet<Culture> Culture { get; set; }
        public virtual DbSet<Dreamcomment> Dreamcomment { get; set; }
        public virtual DbSet<Encryptiontype> Encryptiontype { get; set; }
        public virtual DbSet<Genericattribute> Genericattribute { get; set; }
        public virtual DbSet<Genericattributetype> Genericattributetype { get; set; }
        public virtual DbSet<Genericattributevalue> Genericattributevalue { get; set; }
        public virtual DbSet<Image> Image { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<Orderitem> Orderitem { get; set; }
        public virtual DbSet<Ordernote> Ordernote { get; set; }
        public virtual DbSet<Ordernotetype> Ordernotetype { get; set; }
        public virtual DbSet<Orderstatus> Orderstatus { get; set; }
        public virtual DbSet<Page> Page { get; set; }
        public virtual DbSet<Pagebehavior> Pagebehavior { get; set; }
        public virtual DbSet<Pageculturemap> Pageculturemap { get; set; }
        public virtual DbSet<Pageevent> Pageevent { get; set; }
        public virtual DbSet<Pageimagemap> Pageimagemap { get; set; }
        public virtual DbSet<Pageimagetype> Pageimagetype { get; set; }
        public virtual DbSet<Pagetype> Pagetype { get; set; }
        public virtual DbSet<People> People { get; set; }
        public virtual DbSet<Peoplemacaddress> Peoplemacaddress { get; set; }
        public virtual DbSet<Peopleonline> Peopleonline { get; set; }
        public virtual DbSet<Peopleonlinehistory> Peopleonlinehistory { get; set; }
        public virtual DbSet<Phone> Phone { get; set; }
        public virtual DbSet<Phonetype> Phonetype { get; set; }
        public virtual DbSet<Registrysheet> Registrysheet { get; set; }
        public virtual DbSet<Registrysheetattributemap> Registrysheetattributemap { get; set; }
        public virtual DbSet<Shoppingcart> Shoppingcart { get; set; }
        public virtual DbSet<Shoppingcartbehavior> Shoppingcartbehavior { get; set; }
        public virtual DbSet<Shoppingcartevent> Shoppingcartevent { get; set; }
        public virtual DbSet<Transaction> Transaction { get; set; }
        public virtual DbSet<Transactionprocessor> Transactionprocessor { get; set; }
        public virtual DbSet<Transactionstatus> Transactionstatus { get; set; }
        public virtual DbSet<Transcationtype> Transcationtype { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Userblockchainaddress> Userblockchainaddress { get; set; }
        public virtual DbSet<Usergenericattributemap> Usergenericattributemap { get; set; }
        public virtual DbSet<Userprogrammap> Userprogrammap { get; set; }
        public virtual DbSet<Userverificationstatus> Userverificationstatus { get; set; }
        public virtual DbSet<Workflowcontainer> Workflowcontainer { get; set; }
        public virtual DbSet<Workflowgenericattributemap> Workflowgenericattributemap { get; set; }
        public virtual DbSet<Workflowtype> Workflowtype { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseNpgsql("Host=142.4.211.58;Database=rina90Diet-0.2;Username=pgadmin;Password=glx132@");
                //optionsBuilder.UseNpgsql("Host=10.105.180.153;Database=rina90Diet-0.2;Username=pgadmin;Password=glx132@");
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
                    .HasDefaultValueSql("'2018-11-28'::date");

                entity.Property(e => e.Isabuse).HasColumnName("isabuse");

                entity.Property(e => e.Modifiedby)
                    .IsRequired()
                    .HasColumnName("modifiedby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Modifiedon)
                    .HasColumnName("modifiedon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-11-28'::date");

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.HasOne(d => d.Comment)
                    .WithMany(p => p.Abusecommentmap)
                    .HasForeignKey(d => d.Commentid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_abusecommentmap_comment");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Abusecommentmap)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_abusecommentmap_user");
            });

            modelBuilder.Entity<Accountmailqueue>(entity =>
            {
                entity.HasKey(e => e.Acountmailqueueid);

                entity.ToTable("accountmailqueue");

                entity.Property(e => e.Acountmailqueueid).HasColumnName("acountmailqueueid");

                entity.Property(e => e.Activate).HasColumnName("activate");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasColumnName("createdby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Createdon)
                    .HasColumnName("createdon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-11-28'::date");

                entity.Property(e => e.Message)
                    .HasColumnName("message")
                    .HasColumnType("character varying(255)");

                entity.Property(e => e.Modifiedby)
                    .IsRequired()
                    .HasColumnName("modifiedby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Modifiedon)
                    .HasColumnName("modifiedon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-11-28'::date");

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
                    .HasDefaultValueSql("'2018-11-28'::date");

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
                    .HasDefaultValueSql("'2018-11-28'::date");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("character varying(50)");
            });

            modelBuilder.Entity<Allowanceentrysheet>(entity =>
            {
                entity.ToTable("allowanceentrysheet");

                entity.HasIndex(e => e.Allowanceentrysheetid)
                    .HasName("idx_allowanceentrysheet2");

                entity.Property(e => e.Allowanceentrysheetid)
                    .HasColumnName("allowanceentrysheetid")
                    .ValueGeneratedNever();

                entity.Property(e => e.Allowancesheetid).HasColumnName("allowancesheetid");

                entity.Property(e => e.Blockchainaddress)
                    .IsRequired()
                    .HasColumnName("blockchainaddress")
                    .HasColumnType("character varying(255)");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasColumnName("createdby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Createdon)
                    .HasColumnName("createdon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-11-28'::date");

                entity.Property(e => e.Modifiedby)
                    .IsRequired()
                    .HasColumnName("modifiedby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Modifiedon)
                    .HasColumnName("modifiedon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-11-28'::date");

                entity.Property(e => e.Value)
                    .HasColumnName("value")
                    .HasColumnType("numeric(20,8)");

                entity.HasOne(d => d.Allowancesheet)
                    .WithMany(p => p.Allowanceentrysheet)
                    .HasForeignKey(d => d.Allowancesheetid)
                    .HasConstraintName("fk_allowanc_reference_allowanc");
            });

            modelBuilder.Entity<Allowancesheet>(entity =>
            {
                entity.ToTable("allowancesheet");

                entity.HasIndex(e => e.Allowancesheetid)
                    .HasName("idx_allowancesheet");

                entity.Property(e => e.Allowancesheetid).HasColumnName("allowancesheetid");

                entity.Property(e => e.Blockchainaddress)
                    .IsRequired()
                    .HasColumnName("blockchainaddress")
                    .HasColumnType("character varying(255)");

                entity.Property(e => e.Coinid).HasColumnName("coinid");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasColumnName("createdby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Createdon)
                    .HasColumnName("createdon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-11-28'::date");

                entity.Property(e => e.Modifiedby)
                    .IsRequired()
                    .HasColumnName("modifiedby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Modifiedon)
                    .HasColumnName("modifiedon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-11-28'::date");

                entity.HasOne(d => d.Coin)
                    .WithMany(p => p.Allowancesheet)
                    .HasForeignKey(d => d.Coinid)
                    .HasConstraintName("fk_allowanc_reference_coin");
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
                    .HasDefaultValueSql("'2018-11-28'::date");

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
                    .HasDefaultValueSql("'2018-11-28'::date");

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
                    .HasDefaultValueSql("'2018-11-28'::date");

                entity.Property(e => e.Imageid).HasColumnName("imageid");

                entity.Property(e => e.Modifiedby)
                    .IsRequired()
                    .HasColumnName("modifiedby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Modifiedon)
                    .HasColumnName("modifiedon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-11-28'::date");

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

            modelBuilder.Entity<Balancesheet>(entity =>
            {
                entity.ToTable("balancesheet");

                entity.HasIndex(e => e.Balancesheetid)
                    .HasName("idx_balancesheet");

                entity.Property(e => e.Balancesheetid).HasColumnName("balancesheetid");

                entity.Property(e => e.Blockchainaddress)
                    .IsRequired()
                    .HasColumnName("blockchainaddress")
                    .HasColumnType("character varying(255)");

                entity.Property(e => e.Coinid).HasColumnName("coinid");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasColumnName("createdby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Createdon)
                    .HasColumnName("createdon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-11-28'::date");

                entity.Property(e => e.Modifiedby)
                    .IsRequired()
                    .HasColumnName("modifiedby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Modifiedon)
                    .HasColumnName("modifiedon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-11-28'::date");

                entity.Property(e => e.Value)
                    .HasColumnName("value")
                    .HasColumnType("numeric(20,8)");

                entity.HasOne(d => d.Coin)
                    .WithMany(p => p.Balancesheet)
                    .HasForeignKey(d => d.Coinid)
                    .HasConstraintName("fk_balances_reference_coin");
            });

            modelBuilder.Entity<Bankaccountverificationstatus>(entity =>
            {
                entity.ToTable("bankaccountverificationstatus");

                entity.Property(e => e.Bankaccountverificationstatusid)
                    .HasColumnName("bankaccountverificationstatusid")
                    .HasDefaultValueSql("nextval('bankaccountverificationstatus_bankaccountverificationstatus_seq'::regclass)");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasColumnName("createdby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Createdon)
                    .HasColumnName("createdon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-11-28'::date");

                entity.Property(e => e.Description)
                    .IsRequired()
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
                    .HasDefaultValueSql("'2018-11-28'::date");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("character varying(50)");
            });

            modelBuilder.Entity<Bankdetail>(entity =>
            {
                entity.HasKey(e => e.M);

                entity.ToTable("bankdetail");

                entity.Property(e => e.M).HasColumnName("__m");

                entity.Property(e => e.Bankaccountverificationstatusid).HasColumnName("bankaccountverificationstatusid");

                entity.Property(e => e.Bankname)
                    .HasColumnName("bankname")
                    .HasColumnType("character varying(512)");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasColumnName("city")
                    .HasColumnType("character varying(255)");

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasColumnName("country")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasColumnName("createdby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Createdon)
                    .HasColumnName("createdon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-11-28'::date");

                entity.Property(e => e.Ibannumber)
                    .HasColumnName("ibannumber")
                    .HasColumnType("character varying(255)");

                entity.Property(e => e.Isdefault).HasColumnName("isdefault");

                entity.Property(e => e.Modifiedby)
                    .IsRequired()
                    .HasColumnName("modifiedby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Modifiedon)
                    .HasColumnName("modifiedon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-11-28'::date");

                entity.Property(e => e.Postalcode)
                    .IsRequired()
                    .HasColumnName("postalcode")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.Stateorprovince)
                    .IsRequired()
                    .HasColumnName("stateorprovince")
                    .HasColumnType("character varying(255)");

                entity.Property(e => e.Street1)
                    .IsRequired()
                    .HasColumnName("street1")
                    .HasColumnType("character varying(255)");

                entity.Property(e => e.Street2)
                    .HasColumnName("street2")
                    .HasColumnType("character varying(255)");

                entity.Property(e => e.Switftbicnumber)
                    .HasColumnName("switftbicnumber")
                    .HasColumnType("character varying(255)");

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.HasOne(d => d.Bankaccountverificationstatus)
                    .WithMany(p => p.Bankdetail)
                    .HasForeignKey(d => d.Bankaccountverificationstatusid)
                    .HasConstraintName("fk_bankdeta_reference_bankacco");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Bankdetail)
                    .HasForeignKey(d => d.Userid)
                    .HasConstraintName("fk_bankdeta_reference_user");
            });

            modelBuilder.Entity<Blockchainentity>(entity =>
            {
                entity.ToTable("blockchainentity");

                entity.Property(e => e.Blockchainentityid).HasColumnName("blockchainentityid");

                entity.Property(e => e.Blockchainname)
                    .HasColumnName("blockchainname")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasColumnName("createdby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Createdon)
                    .HasColumnName("createdon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-11-28'::date");

                entity.Property(e => e.Isdefault).HasColumnName("isdefault");

                entity.Property(e => e.Modifiedby)
                    .IsRequired()
                    .HasColumnName("modifiedby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Modifiedon)
                    .HasColumnName("modifiedon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-11-28'::date");
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
                    .HasDefaultValueSql("'2018-11-28'::date");

                entity.Property(e => e.Isdefault).HasColumnName("isdefault");

                entity.Property(e => e.Modifiedby)
                    .IsRequired()
                    .HasColumnName("modifiedby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Modifiedon)
                    .HasColumnName("modifiedon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-11-28'::date");

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
                    .HasDefaultValueSql("'2018-11-28'::date");

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
                    .HasDefaultValueSql("'2018-11-28'::date");

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
                    .HasDefaultValueSql("'2018-11-28'::date");

                entity.Property(e => e.Imageid).HasColumnName("imageid");

                entity.Property(e => e.Modifiedby)
                    .IsRequired()
                    .HasColumnName("modifiedby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Modifiedon)
                    .HasColumnName("modifiedon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-11-28'::date");

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

            modelBuilder.Entity<Coin>(entity =>
            {
                entity.ToTable("coin");

                entity.HasIndex(e => e.Coinid)
                    .HasName("idx_coinid");

                entity.Property(e => e.Coinid).HasColumnName("coinid");

                entity.Property(e => e.Blockchainentityid).HasColumnName("blockchainentityid");

                entity.Property(e => e.Coinlabel)
                    .HasColumnName("coinlabel")
                    .HasColumnType("character varying(1024)");

                entity.Property(e => e.Coinname)
                    .HasColumnName("coinname")
                    .HasColumnType("character varying(512)");

                entity.Property(e => e.Coinsymbol)
                    .HasColumnName("coinsymbol")
                    .HasColumnType("character varying(20)");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasColumnName("createdby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Createdon)
                    .HasColumnName("createdon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-11-28'::date");

                entity.Property(e => e.Modifiedby)
                    .IsRequired()
                    .HasColumnName("modifiedby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Modifiedon)
                    .HasColumnName("modifiedon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-11-28'::date");

                entity.HasOne(d => d.Blockchainentity)
                    .WithMany(p => p.Coin)
                    .HasForeignKey(d => d.Blockchainentityid)
                    .HasConstraintName("fk_coin_reference_blockcha");
            });

            modelBuilder.Entity<Coingenericattributemap>(entity =>
            {
                entity.HasKey(e => e.Coinattributeid);

                entity.ToTable("coingenericattributemap");

                entity.Property(e => e.Coinattributeid).HasColumnName("coinattributeid");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.Coinid).HasColumnName("coinid");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasColumnName("createdby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Createdon)
                    .HasColumnName("createdon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-11-28'::date");

                entity.Property(e => e.Genericattributeid).HasColumnName("genericattributeid");

                entity.Property(e => e.Modifiedby)
                    .IsRequired()
                    .HasColumnName("modifiedby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Modifiedon)
                    .HasColumnName("modifiedon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-11-28'::date");

                entity.HasOne(d => d.Coin)
                    .WithMany(p => p.Coingenericattributemap)
                    .HasForeignKey(d => d.Coinid)
                    .HasConstraintName("fk_coingene_reference_coin");

                entity.HasOne(d => d.Genericattribute)
                    .WithMany(p => p.Coingenericattributemap)
                    .HasForeignKey(d => d.Genericattributeid)
                    .HasConstraintName("fk_coingene_reference_generica");
            });

            modelBuilder.Entity<Coinledger>(entity =>
            {
                entity.ToTable("coinledger");

                entity.HasIndex(e => e.Coinledgerid)
                    .HasName("ix_coinledgerid");

                entity.Property(e => e.Coinledgerid).HasColumnName("coinledgerid");

                entity.Property(e => e.Coinid).HasColumnName("coinid");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasColumnName("createdby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Createdon)
                    .HasColumnName("createdon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-11-28'::date");

                entity.Property(e => e.Credit)
                    .HasColumnName("credit")
                    .HasColumnType("numeric(12,4)");

                entity.Property(e => e.Debit)
                    .HasColumnName("debit")
                    .HasColumnType("numeric(12,4)");

                entity.Property(e => e.Modifiedby)
                    .IsRequired()
                    .HasColumnName("modifiedby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Modifiedon)
                    .HasColumnName("modifiedon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-11-28'::date");

                entity.Property(e => e.Orderid).HasColumnName("orderid");

                entity.Property(e => e.Transactiontypeid).HasColumnName("transactiontypeid");

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.HasOne(d => d.Coin)
                    .WithMany(p => p.Coinledger)
                    .HasForeignKey(d => d.Coinid)
                    .HasConstraintName("fk_coinledg_reference_coin");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.Coinledger)
                    .HasForeignKey(d => d.Orderid)
                    .HasConstraintName("fk_coinledg_reference_order");

                entity.HasOne(d => d.Transactiontype)
                    .WithMany(p => p.Coinledger)
                    .HasForeignKey(d => d.Transactiontypeid)
                    .HasConstraintName("fk_coinledg_reference_transcat");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Coinledger)
                    .HasForeignKey(d => d.Userid)
                    .HasConstraintName("fk_coinledg_reference_user");
            });

            modelBuilder.Entity<Coinledgercoinwalletmap>(entity =>
            {
                entity.ToTable("coinledgercoinwalletmap");

                entity.HasIndex(e => e.Coinledgercoinwalletmapid)
                    .HasName("idx_coinledgercoinwalletmapid");

                entity.Property(e => e.Coinledgercoinwalletmapid).HasColumnName("coinledgercoinwalletmapid");

                entity.Property(e => e.Coinledgerid).HasColumnName("coinledgerid");

                entity.Property(e => e.Coinwalletid).HasColumnName("coinwalletid");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasColumnName("createdby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Createdon)
                    .HasColumnName("createdon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-11-28'::date");

                entity.Property(e => e.Modifiedby)
                    .IsRequired()
                    .HasColumnName("modifiedby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Modifiedon)
                    .HasColumnName("modifiedon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-11-28'::date");

                entity.HasOne(d => d.Coinledger)
                    .WithMany(p => p.Coinledgercoinwalletmap)
                    .HasForeignKey(d => d.Coinledgerid)
                    .HasConstraintName("fk_coinledg_reference_coinledg");

                entity.HasOne(d => d.Coinwallet)
                    .WithMany(p => p.Coinledgercoinwalletmap)
                    .HasForeignKey(d => d.Coinwalletid)
                    .HasConstraintName("fk_coinledg_reference_coinwall");
            });

            modelBuilder.Entity<Coinwallet>(entity =>
            {
                entity.ToTable("coinwallet");

                entity.HasIndex(e => e.Coinwalletid)
                    .HasName("idx_coinwallet");

                entity.Property(e => e.Coinwalletid).HasColumnName("coinwalletid");

                entity.Property(e => e.Activate).HasColumnName("activate");

                entity.Property(e => e.Coinaccountbalanceamount)
                    .HasColumnName("coinaccountbalanceamount")
                    .HasColumnType("numeric(12,4)");

                entity.Property(e => e.Coinid).HasColumnName("coinid");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasColumnName("createdby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Createdon)
                    .HasColumnName("createdon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-11-28'::date");

                entity.Property(e => e.Modifiedby)
                    .IsRequired()
                    .HasColumnName("modifiedby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Userblockchainaddressid).HasColumnName("userblockchainaddressid");

                entity.Property(e => e.Modifiedon)
                    .HasColumnName("modifiedon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-11-28'::date");

                entity.Property(e => e.Totalcredit)
                    .HasColumnName("totalcredit")
                    .HasColumnType("numeric(12,4)");

                entity.Property(e => e.Totaldebit)
                    .HasColumnName("totaldebit")
                    .HasColumnType("numeric(12,4)");

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.HasOne(d => d.Coin)
                    .WithMany(p => p.Coinwallet)
                    .HasForeignKey(d => d.Coinid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_coinwall_reference_coin");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Coinwallet)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_coinwall_reference_user");
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
                    .HasDefaultValueSql("'2018-11-28'::date");

                entity.Property(e => e.Modifiedby)
                    .IsRequired()
                    .HasColumnName("modifiedby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Modifiedon)
                    .HasColumnName("modifiedon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-11-28'::date");

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
                    .HasDefaultValueSql("'2018-11-28'::date");

                entity.Property(e => e.Modifiedby)
                    .IsRequired()
                    .HasColumnName("modifiedby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Modifiedon)
                    .HasColumnName("modifiedon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-11-28'::date");

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
                    .HasDefaultValueSql("'2018-11-28'::date");

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
                    .HasDefaultValueSql("'2018-11-28'::date");

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
                    .HasDefaultValueSql("'2018-11-28'::date");

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
                    .HasDefaultValueSql("'2018-11-28'::date");

                entity.Property(e => e.Pageid).HasColumnName("pageid");

                entity.Property(e => e.Sort).HasColumnName("sort");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title")
                    .HasColumnType("character varying(1024)");

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
                    .HasDefaultValueSql("'2018-11-28'::date");

                entity.Property(e => e.Cultureid).HasColumnName("cultureid");

                entity.Property(e => e.Modifiedby)
                    .IsRequired()
                    .HasColumnName("modifiedby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Modifiedon)
                    .HasColumnName("modifiedon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-11-28'::date");

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
                    .HasDefaultValueSql("'2018-11-28'::date");

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
                    .HasDefaultValueSql("'2018-11-28'::date");

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
                    .HasDefaultValueSql("'2018-11-28'::date");

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
                    .HasDefaultValueSql("'2018-11-28'::date");

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
                    .HasDefaultValueSql("'2018-11-28'::date");

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
                    .HasDefaultValueSql("'2018-11-28'::date");
            });

            modelBuilder.Entity<Dreamcomment>(entity =>
            {
                entity.HasKey(e => e.Commentid);

                entity.ToTable("dreamcomment");

                entity.Property(e => e.Commentid).HasColumnName("commentid");

                entity.Property(e => e.Content)
                    .HasColumnName("content")
                    .HasColumnType("character varying(4096)");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasColumnName("createdby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Createdon)
                    .HasColumnName("createdon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-11-28'::date");

                entity.Property(e => e.Modifiedby)
                    .IsRequired()
                    .HasColumnName("modifiedby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Modifiedon)
                    .HasColumnName("modifiedon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-11-28'::date");

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.Property(e => e.Vote).HasColumnName("vote");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Dreamcomment)
                    .HasForeignKey(d => d.Userid)
                    .HasConstraintName("fk_dreamcomment_user");
            });

            modelBuilder.Entity<Encryptiontype>(entity =>
            {
                entity.HasKey(e => e.Encryptionid);

                entity.ToTable("encryptiontype");

                entity.Property(e => e.Encryptionid).HasColumnName("encryptionid");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasColumnName("createdby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Createdon)
                    .HasColumnName("createdon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-11-28'::date");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("character varying(255)");

                entity.Property(e => e.Encryptionname)
                    .IsRequired()
                    .HasColumnName("encryptionname")
                    .HasColumnType("character varying(100)");

                entity.Property(e => e.Modifiedby)
                    .IsRequired()
                    .HasColumnName("modifiedby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Modifiedon)
                    .HasColumnName("modifiedon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-11-28'::date");
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
                    .HasDefaultValueSql("'2018-11-28'::date");

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
                    .HasDefaultValueSql("'2018-11-28'::date");

                entity.Property(e => e.Typelabelstring)
                    .HasColumnName("typelabelstring")
                    .HasColumnType("character varying(4096)");

                entity.Property(e => e.Typestring)
                    .HasColumnName("typestring")
                    .HasColumnType("character varying(1024)");

                entity.Property(e => e.Valuelabelstring)
                    .HasColumnName("valuelabelstring")
                    .HasColumnType("character varying(4096)");

                entity.Property(e => e.Valuestring)
                    .HasColumnName("valuestring")
                    .HasColumnType("character varying(4096)");

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
                    .HasColumnType("character varying(512)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Createdon)
                    .HasColumnName("createdon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-11-28'::date");

                entity.Property(e => e.Metatypelabel).HasColumnName("metatypelabel");

                entity.Property(e => e.Metatypestring)
                    .HasColumnName("metatypestring")
                    .HasColumnType("character varying(512)");

                entity.Property(e => e.Modifiedby)
                    .IsRequired()
                    .HasColumnName("modifiedby")
                    .HasColumnType("character varying(512)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Modifiedon)
                    .HasColumnName("modifiedon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-11-28'::date");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("character varying(255)");

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

                entity.Property(e => e.Valuelabelstring)
                    .HasColumnName("valuelabelstring")
                    .HasColumnType("character varying(4096)");

                entity.Property(e => e.Valuenumber)
                    .HasColumnName("valuenumber")
                    .HasColumnType("numeric(12,4)");

                entity.Property(e => e.Valuestring)
                    .HasColumnName("valuestring")
                    .HasColumnType("character varying(4096)");

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
                    .HasDefaultValueSql("'2018-11-28'::date");

                entity.Property(e => e.Label)
                    .HasColumnName("label")
                    .HasColumnType("character varying(150)");

                entity.Property(e => e.Metatypelabel)
                    .HasColumnName("metatypelabel")
                    .HasColumnType("character varying");

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
                    .HasDefaultValueSql("'2018-11-28'::date");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("character varying(250)");

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

                entity.Property(e => e.Valuelabelstring)
                    .HasColumnName("valuelabelstring")
                    .HasColumnType("character varying");

                entity.Property(e => e.Valuenumber)
                    .HasColumnName("valuenumber")
                    .HasColumnType("numeric(12,4)");

                entity.Property(e => e.Valuestring)
                    .HasColumnName("valuestring")
                    .HasColumnType("character varying(4096)");
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
                    .HasDefaultValueSql("'2018-11-28'::date");

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
                    .HasDefaultValueSql("'2018-11-28'::date");

                entity.Property(e => e.Thumburl)
                    .HasColumnName("thumburl")
                    .HasColumnType("character varying(255)");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.ToTable("order");

                entity.Property(e => e.Orderid).HasColumnName("orderid");

                entity.Property(e => e.Coinid).HasColumnName("coinid");

                entity.Property(e => e.Couponamount)
                    .HasColumnName("couponamount")
                    .HasColumnType("money");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasColumnName("createdby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Createdon)
                    .HasColumnName("createdon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-11-28'::date");

                entity.Property(e => e.Cultureid).HasColumnName("cultureid");

                entity.Property(e => e.Dateshipped)
                    .HasColumnName("dateshipped")
                    .HasColumnType("date");

                entity.Property(e => e.Estimateddelivery)
                    .HasColumnName("estimateddelivery")
                    .HasColumnType("date");

                entity.Property(e => e.Executedon)
                    .HasColumnName("executedon")
                    .HasColumnType("date");

                entity.Property(e => e.Finaltotal)
                    .HasColumnName("finaltotal")
                    .HasColumnType("money");

                entity.Property(e => e.Grandtotal)
                    .HasColumnName("grandtotal")
                    .HasColumnType("money");

                entity.Property(e => e.Modifiedby)
                    .IsRequired()
                    .HasColumnName("modifiedby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Modifiedon)
                    .HasColumnName("modifiedon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-11-28'::date");

                entity.Property(e => e.Ordernumber)
                    .HasColumnName("ordernumber")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.Orderstatusid).HasColumnName("orderstatusid");

                entity.Property(e => e.Shippingamount)
                    .HasColumnName("shippingamount")
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Subshippingtotal)
                    .HasColumnName("subshippingtotal")
                    .HasColumnType("money");

                entity.Property(e => e.Subtotal)
                    .HasColumnName("subtotal")
                    .HasColumnType("money");

                entity.Property(e => e.Subweeetotal)
                    .HasColumnName("subweeetotal")
                    .HasColumnType("money");

                entity.Property(e => e.Taxamount)
                    .HasColumnName("taxamount")
                    .HasColumnType("money");

                entity.Property(e => e.Trackingnumber)
                    .HasColumnName("trackingnumber")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.Property(e => e.Weeeamount)
                    .HasColumnName("weeeamount")
                    .HasColumnType("money");

                entity.HasOne(d => d.Coin)
                    .WithMany(p => p.Order)
                    .HasForeignKey(d => d.Coinid)
                    .HasConstraintName("fk_order_reference_coin");

                entity.HasOne(d => d.Culture)
                    .WithMany(p => p.Order)
                    .HasForeignKey(d => d.Cultureid)
                    .HasConstraintName("fk_order_culture");

                entity.HasOne(d => d.Orderstatus)
                    .WithMany(p => p.Order)
                    .HasForeignKey(d => d.Orderstatusid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_order_orderstatus");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Order)
                    .HasForeignKey(d => d.Userid)
                    .HasConstraintName("fk_order_user");
            });

            modelBuilder.Entity<Orderitem>(entity =>
            {
                entity.ToTable("orderitem");

                entity.Property(e => e.Orderitemid).HasColumnName("orderitemid");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasColumnName("createdby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Createdon)
                    .HasColumnName("createdon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-11-28'::date");

                entity.Property(e => e.Discountamount)
                    .HasColumnName("discountamount")
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Grandprice)
                    .HasColumnName("grandprice")
                    .HasColumnType("money");

                entity.Property(e => e.Modifiedby)
                    .IsRequired()
                    .HasColumnName("modifiedby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Modifiedon)
                    .HasColumnName("modifiedon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-11-28'::date");

                entity.Property(e => e.Orderid).HasColumnName("orderid");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.Totalprice)
                    .HasColumnName("totalprice")
                    .HasColumnType("money");

                entity.Property(e => e.Totaltaxprice)
                    .HasColumnName("totaltaxprice")
                    .HasColumnType("money");

                entity.Property(e => e.Unitprice)
                    .HasColumnName("unitprice")
                    .HasColumnType("money");

                entity.Property(e => e.Unittaxprice)
                    .HasColumnName("unittaxprice")
                    .HasColumnType("money");

                entity.Property(e => e.Weeeprice)
                    .HasColumnName("weeeprice")
                    .HasColumnType("money");

                entity.Property(e => e.Weeetaxprice)
                    .HasColumnName("weeetaxprice")
                    .HasColumnType("money");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.Orderitem)
                    .HasForeignKey(d => d.Orderid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_orderitem_order");
            });

            modelBuilder.Entity<Ordernote>(entity =>
            {
                entity.ToTable("ordernote");

                entity.Property(e => e.Ordernoteid).HasColumnName("ordernoteid");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasColumnName("createdby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Createdon)
                    .HasColumnName("createdon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-11-28'::date");

                entity.Property(e => e.Modifiedby)
                    .IsRequired()
                    .HasColumnName("modifiedby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Modifiedon)
                    .HasColumnName("modifiedon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-11-28'::date");

                entity.Property(e => e.Note).HasColumnName("note");

                entity.Property(e => e.Orderid).HasColumnName("orderid");

                entity.Property(e => e.Ordernotetypeid).HasColumnName("ordernotetypeid");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.Ordernote)
                    .HasForeignKey(d => d.Orderid)
                    .HasConstraintName("fk_ordernote_order");

                entity.HasOne(d => d.Ordernotetype)
                    .WithMany(p => p.Ordernote)
                    .HasForeignKey(d => d.Ordernotetypeid)
                    .HasConstraintName("fk_ordernote_ordernotetype");
            });

            modelBuilder.Entity<Ordernotetype>(entity =>
            {
                entity.ToTable("ordernotetype");

                entity.Property(e => e.Ordernotetypeid).HasColumnName("ordernotetypeid");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasColumnName("createdby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Createdon)
                    .HasColumnName("createdon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-11-28'::date");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("character varying(150)");

                entity.Property(e => e.Modifiedby)
                    .IsRequired()
                    .HasColumnName("modifiedby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Modifiedon)
                    .HasColumnName("modifiedon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-11-28'::date");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasColumnType("character varying(50)");
            });

            modelBuilder.Entity<Orderstatus>(entity =>
            {
                entity.ToTable("orderstatus");

                entity.Property(e => e.Orderstatusid).HasColumnName("orderstatusid");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasColumnName("createdby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Createdon)
                    .HasColumnName("createdon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-11-28'::date");

                entity.Property(e => e.Description)
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
                    .HasDefaultValueSql("'2018-11-28'::date");
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
                    .HasDefaultValueSql("'2018-11-28'::date");

                entity.Property(e => e.Isdefault).HasColumnName("isdefault");

                entity.Property(e => e.Modifiedby)
                    .IsRequired()
                    .HasColumnName("modifiedby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Modifiedon)
                    .HasColumnName("modifiedon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-11-28'::date");

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
                    .HasDefaultValueSql("'2018-11-28'::date");

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
                    .HasDefaultValueSql("'2018-11-28'::date");
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
                    .HasDefaultValueSql("'2018-11-28'::date");

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
                    .HasDefaultValueSql("'2018-11-28'::date");

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
                    .HasDefaultValueSql("'2018-11-28'::date");

                entity.Property(e => e.Eventdate)
                    .HasColumnName("eventdate")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-11-28'::date");

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
                    .HasDefaultValueSql("'2018-11-28'::date");

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
                    .HasDefaultValueSql("'2018-11-28'::date");

                entity.Property(e => e.Imageid).HasColumnName("imageid");

                entity.Property(e => e.Modifiedby)
                    .IsRequired()
                    .HasColumnName("modifiedby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Modifiedon)
                    .HasColumnName("modifiedon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-11-28'::date");

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
                    .HasDefaultValueSql("'2018-11-28'::date");

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
                    .HasDefaultValueSql("'2018-11-28'::date");

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
                    .HasDefaultValueSql("'2018-11-28'::date");

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
                    .HasDefaultValueSql("'2018-11-28'::date");

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
                    .HasDefaultValueSql("'2018-11-28'::date");

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

                entity.Property(e => e.Dateofbirth)
                    .HasColumnName("dateofbirth")
                    .HasColumnType("date");

                entity.Property(e => e.Nationality)
                    .HasColumnName("nationality")
                    .HasColumnType("character varying(512)");

                entity.Property(e => e.Addressline1)
                    .HasColumnName("addressline1")
                    .HasColumnType("character varying(1024)");

                entity.Property(e => e.Addressline2)
                    .HasColumnName("addressline2")
                    .HasColumnType("character varying(1024)");

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasColumnType("character varying(1024)");

                entity.Property(e => e.Zipcode)
                    .HasColumnName("zipcode")
                    .HasColumnType("character varying(1024)");

                entity.Property(e => e.Country)
                    .HasColumnName("country")
                    .HasColumnType("character varying(1024)");

                entity.Property(e => e.Phonenumber)
                    .HasColumnName("phonenumber")
                    .HasColumnType("character varying(1024)");

                entity.Property(e => e.Telegramuser)
                    .HasColumnName("telegramuser")
                    .HasColumnType("character varying(1024)");

                entity.Property(e => e.Modifiedby)
                    .IsRequired()
                    .HasColumnName("modifiedby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Modifiedon)
                    .HasColumnName("modifiedon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-11-28'::date");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasColumnType("character varying(255)");
            });

            modelBuilder.Entity<Peoplemacaddress>(entity =>
            {
                entity.ToTable("peoplemacaddress");

                entity.HasIndex(e => e.Peoplemacaddressid)
                    .HasName("index_peoplemacaddressid");

                entity.Property(e => e.Peoplemacaddressid).HasColumnName("peoplemacaddressid");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasColumnName("createdby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Createdon)
                    .HasColumnName("createdon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-11-28'::date");

                entity.Property(e => e.Macaddress)
                    .IsRequired()
                    .HasColumnName("macaddress")
                    .HasColumnType("character varying(1024)");

                entity.Property(e => e.Modifiedby)
                    .IsRequired()
                    .HasColumnName("modifiedby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Modifiedon)
                    .HasColumnName("modifiedon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-11-28'::date");

                entity.Property(e => e.Peopleid).HasColumnName("peopleid");

                entity.HasOne(d => d.People)
                    .WithMany(p => p.Peoplemacaddress)
                    .HasForeignKey(d => d.Peopleid)
                    .HasConstraintName("fk_peoplema_reference_people");
            });

            modelBuilder.Entity<Peopleonline>(entity =>
            {
                entity.ToTable("peopleonline");

                entity.Property(e => e.Peopleonlineid).HasColumnName("peopleonlineid");

                entity.Property(e => e.Browser)
                    .IsRequired()
                    .HasColumnName("browser")
                    .HasColumnType("character varying(200)");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasColumnName("createdby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Createdon)
                    .HasColumnName("createdon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-11-28'::date");

                entity.Property(e => e.Ip)
                    .IsRequired()
                    .HasColumnName("ip")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.Lastactivity)
                    .HasColumnName("lastactivity")
                    .HasColumnType("date");

                entity.Property(e => e.Modifiedby)
                    .IsRequired()
                    .HasColumnName("modifiedby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Modifiedon)
                    .HasColumnName("modifiedon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-11-28'::date");

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Peopleonline)
                    .HasForeignKey(d => d.Userid)
                    .HasConstraintName("fk_peopleonline_user");
            });

            modelBuilder.Entity<Peopleonlinehistory>(entity =>
            {
                entity.ToTable("peopleonlinehistory");

                entity.Property(e => e.Peopleonlinehistoryid).HasColumnName("peopleonlinehistoryid");

                entity.Property(e => e.Browser)
                    .IsRequired()
                    .HasColumnName("browser")
                    .HasColumnType("character varying(200)");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasColumnName("createdby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Createdon)
                    .HasColumnName("createdon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-11-28'::date");

                entity.Property(e => e.Durationminute)
                    .HasColumnName("durationminute")
                    .HasColumnType("numeric(18,2)");

                entity.Property(e => e.Endactivity)
                    .HasColumnName("endactivity")
                    .HasColumnType("date");

                entity.Property(e => e.Firstactivity)
                    .HasColumnName("firstactivity")
                    .HasColumnType("date");

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
                    .HasDefaultValueSql("'2018-11-28'::date");

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Peopleonlinehistory)
                    .HasForeignKey(d => d.Userid)
                    .HasConstraintName("fk_peopleonlinehistory_user");
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
                    .HasDefaultValueSql("'2018-11-28'::date");

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
                    .HasDefaultValueSql("'2018-11-28'::date");

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
                    .HasDefaultValueSql("'2018-11-28'::date");

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
                    .HasDefaultValueSql("'2018-11-28'::date");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("character varying(50)");
            });

            modelBuilder.Entity<Registrysheet>(entity =>
            {
                entity.ToTable("registrysheet");

                entity.HasIndex(e => e.Registrysheetid)
                    .HasName("idx_registrysheet");

                entity.Property(e => e.Registrysheetid).HasColumnName("registrysheetid");

                entity.Property(e => e.Blockchainaddress)
                    .IsRequired()
                    .HasColumnName("blockchainaddress")
                    .HasColumnType("character varying(255)");

                entity.Property(e => e.Coinid).HasColumnName("coinid");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasColumnName("createdby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Createdon)
                    .HasColumnName("createdon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-11-28'::date");

                entity.Property(e => e.Modifiedby)
                    .IsRequired()
                    .HasColumnName("modifiedby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Modifiedon)
                    .HasColumnName("modifiedon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-11-28'::date");

                entity.HasOne(d => d.Coin)
                    .WithMany(p => p.Registrysheet)
                    .HasForeignKey(d => d.Coinid)
                    .HasConstraintName("fk_registry_reference_coin");
            });

            modelBuilder.Entity<Registrysheetattributemap>(entity =>
            {
                entity.HasKey(e => e.Registrysheetgenericattributeid);

                entity.ToTable("registrysheetattributemap");

                entity.HasIndex(e => e.Registrysheetgenericattributeid)
                    .HasName("idx_registrysheetam");

                entity.Property(e => e.Registrysheetgenericattributeid).HasColumnName("registrysheetgenericattributeid");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasColumnName("createdby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Createdon)
                    .HasColumnName("createdon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-11-28'::date");

                entity.Property(e => e.Genericattributeid).HasColumnName("genericattributeid");

                entity.Property(e => e.Modifiedby)
                    .IsRequired()
                    .HasColumnName("modifiedby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Modifiedon)
                    .HasColumnName("modifiedon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-11-28'::date");

                entity.Property(e => e.Registrysheetid).HasColumnName("registrysheetid");

                entity.HasOne(d => d.Genericattribute)
                    .WithMany(p => p.Registrysheetattributemap)
                    .HasForeignKey(d => d.Genericattributeid)
                    .HasConstraintName("fk_registry_reference_generica");

                entity.HasOne(d => d.Registrysheet)
                    .WithMany(p => p.Registrysheetattributemap)
                    .HasForeignKey(d => d.Registrysheetid)
                    .HasConstraintName("fk_registry_reference_registry");
            });

            modelBuilder.Entity<Shoppingcart>(entity =>
            {
                entity.HasKey(e => e._);

                entity.ToTable("shoppingcart");

                entity.Property(e => e.Activate).HasColumnName("activate");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasColumnName("createdby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Createdon)
                    .HasColumnName("createdon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-11-28'::date");

                entity.Property(e => e.Cultureid).HasColumnName("cultureid");

                entity.Property(e => e.Grandtotal)
                    .HasColumnName("grandtotal")
                    .HasColumnType("money");

                entity.Property(e => e.Modifiedby)
                    .IsRequired()
                    .HasColumnName("modifiedby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Modifiedon)
                    .HasColumnName("modifiedon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-11-28'::date");

                entity.Property(e => e.Shoppingcartguid)
                    .IsRequired()
                    .HasColumnName("shoppingcartguid")
                    .HasColumnType("character varying(36)");

                entity.Property(e => e.Subtotal)
                    .HasColumnName("subtotal")
                    .HasColumnType("money");

                entity.Property(e => e.Taxamount)
                    .HasColumnName("taxamount")
                    .HasColumnType("money");

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.HasOne(d => d.Culture)
                    .WithMany(p => p.Shoppingcart)
                    .HasForeignKey(d => d.Cultureid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_shoppingcart_culture");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Shoppingcart)
                    .HasForeignKey(d => d.Userid)
                    .HasConstraintName("fk_shoppingcart_user");
            });

            modelBuilder.Entity<Shoppingcartbehavior>(entity =>
            {
                entity.ToTable("shoppingcartbehavior");

                entity.Property(e => e.Shoppingcartbehaviorid).HasColumnName("shoppingcartbehaviorid");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasColumnName("createdby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Createdon)
                    .HasColumnName("createdon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-11-28'::date");

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
                    .HasDefaultValueSql("'2018-11-28'::date");
            });

            modelBuilder.Entity<Shoppingcartevent>(entity =>
            {
                entity.ToTable("shoppingcartevent");

                entity.Property(e => e.Shoppingcarteventid).HasColumnName("shoppingcarteventid");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasColumnName("createdby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Createdon)
                    .HasColumnName("createdon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-11-28'::date");

                entity.Property(e => e.Eventcontent)
                    .HasColumnName("eventcontent")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.Eventdate)
                    .HasColumnName("eventdate")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-11-28'::date");

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
                    .HasDefaultValueSql("'2018-11-28'::date");

                entity.Property(e => e.Oldeventcontent)
                    .HasColumnName("oldeventcontent")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.Shoppingcartbehaviorid).HasColumnName("shoppingcartbehaviorid");

                entity.Property(e => e.Shoppingcartid).HasColumnName("shoppingcartid");

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.HasOne(d => d.Shoppingcartbehavior)
                    .WithMany(p => p.Shoppingcartevent)
                    .HasForeignKey(d => d.Shoppingcartbehaviorid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_sce_scbehavior");

                entity.HasOne(d => d.Shoppingcart)
                    .WithMany(p => p.Shoppingcartevent)
                    .HasForeignKey(d => d.Shoppingcartid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_sce_scart");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Shoppingcartevent)
                    .HasForeignKey(d => d.Userid)
                    .HasConstraintName("fk_shoppingcartevent_user");
            });

            modelBuilder.Entity<Transaction>(entity =>
            {
                entity.ToTable("transaction");

                entity.Property(e => e.Transactionid).HasColumnName("transactionid");

                entity.Property(e => e.Amount)
                    .HasColumnName("amount")
                    .HasColumnType("money");

                entity.Property(e => e.Amountauthorized)
                    .HasColumnName("amountauthorized")
                    .HasColumnType("numeric(18,10)");

                entity.Property(e => e.Amountcharged)
                    .HasColumnName("amountcharged")
                    .HasColumnType("numeric(18,10)");

                entity.Property(e => e.Amountrefunded)
                    .HasColumnName("amountrefunded")
                    .HasColumnType("numeric(18,10)");

                entity.Property(e => e.Authorizationcode)
                    .HasColumnName("authorizationcode")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.Checknumber)
                    .HasColumnName("checknumber")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.Coinledgerid).HasColumnName("coinledgerid");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasColumnName("createdby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Createdon)
                    .HasColumnName("createdon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-11-28'::date");

                entity.Property(e => e.Creditcardcvn)
                    .HasColumnName("creditcardcvn")
                    .HasColumnType("character varying(10)");

                entity.Property(e => e.Creditcardencrypted)
                    .HasColumnName("creditcardencrypted")
                    .HasColumnType("character varying(512)");

                entity.Property(e => e.Creditcardexp)
                    .HasColumnName("creditcardexp")
                    .HasColumnType("date");

                entity.Property(e => e.Creditcardholder)
                    .HasColumnName("creditcardholder")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.Creditcardnumber)
                    .HasColumnName("creditcardnumber")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.Creditcardtypeid).HasColumnName("creditcardtypeid");

                entity.Property(e => e.Giftcertificatenumber)
                    .HasColumnName("giftcertificatenumber")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.Modifiedby)
                    .IsRequired()
                    .HasColumnName("modifiedby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Modifiedon)
                    .HasColumnName("modifiedon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-11-28'::date");

                entity.Property(e => e.Note)
                    .HasColumnName("note")
                    .HasColumnType("character varying(255)");

                entity.Property(e => e.Orderid).HasColumnName("orderid");

                entity.Property(e => e.Pointofsaleid).HasColumnName("pointofsaleid");

                entity.Property(e => e.Processorid).HasColumnName("processorid");

                entity.Property(e => e.Transactiondate)
                    .HasColumnName("transactiondate")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-11-28'::date");

                entity.Property(e => e.Transactionreferencenumber)
                    .HasColumnName("transactionreferencenumber")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.Transactionresponsecode)
                    .HasColumnName("transactionresponsecode")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.Transactionstatusid).HasColumnName("transactionstatusid");

                entity.HasOne(d => d.Coinledger)
                    .WithMany(p => p.Transaction)
                    .HasForeignKey(d => d.Coinledgerid)
                    .HasConstraintName("fk_transact_reference_coinledg");

                entity.HasOne(d => d.Creditcardtype)
                    .WithMany(p => p.Transaction)
                    .HasForeignKey(d => d.Creditcardtypeid)
                    .HasConstraintName("fk_transaction_creditcardtype");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.Transaction)
                    .HasForeignKey(d => d.Orderid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_transactions_orders");

                entity.HasOne(d => d.Processor)
                    .WithMany(p => p.Transaction)
                    .HasForeignKey(d => d.Processorid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_t_tprocessors");

                entity.HasOne(d => d.Transactionstatus)
                    .WithMany(p => p.Transaction)
                    .HasForeignKey(d => d.Transactionstatusid)
                    .HasConstraintName("fk_t_tstatus");
            });

            modelBuilder.Entity<Transactionprocessor>(entity =>
            {
                entity.HasKey(e => e.Processorid);

                entity.ToTable("transactionprocessor");

                entity.Property(e => e.Processorid).HasColumnName("processorid");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasColumnName("createdby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Createdon)
                    .HasColumnName("createdon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-11-28'::date");

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
                    .HasDefaultValueSql("'2018-11-28'::date");
            });

            modelBuilder.Entity<Transactionstatus>(entity =>
            {
                entity.ToTable("transactionstatus");

                entity.Property(e => e.Transactionstatusid).HasColumnName("transactionstatusid");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasColumnName("createdby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Createdon)
                    .HasColumnName("createdon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-11-28'::date");

                entity.Property(e => e.Modifiedby)
                    .IsRequired()
                    .HasColumnName("modifiedby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Modifiedon)
                    .HasColumnName("modifiedon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-11-28'::date");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasColumnType("character varying(50)");
            });

            modelBuilder.Entity<Transcationtype>(entity =>
            {
                entity.HasKey(e => e.Transactiontypeid);

                entity.ToTable("transcationtype");

                entity.HasIndex(e => e.Transactiontypeid)
                    .HasName("idx_transactiontypeid");

                entity.Property(e => e.Transactiontypeid).HasColumnName("transactiontypeid");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasColumnName("createdby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Createdon)
                    .HasColumnName("createdon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-11-28'::date");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("character varying(1024)");

                entity.Property(e => e.Modifiedby)
                    .IsRequired()
                    .HasColumnName("modifiedby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Modifiedon)
                    .HasColumnName("modifiedon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-11-28'::date");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("character varying(512)");
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
                    .HasDefaultValueSql("'2018-11-28'::date");

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
                    .HasDefaultValueSql("'2018-11-28'::date");

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

                entity.HasOne(d => d.Encryption)
                    .WithMany(p => p.User)
                    .HasForeignKey(d => d.Encryptionid)
                    .HasConstraintName("fk_user_encryptiontype");

                entity.HasOne(d => d.People)
                    .WithMany(p => p.User)
                    .HasForeignKey(d => d.Peopleid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_user_people");

                entity.HasOne(d => d.Userverificationstatus)
                    .WithMany(p => p.User)
                    .HasForeignKey(d => d.Userverificationstatusid)
                    .HasConstraintName("fk_user_reference_userveri");
            });

            modelBuilder.Entity<Userblockchainaddress>(entity =>
            {
                entity.ToTable("userblockchainaddress");

                entity.HasIndex(e => e.Userblockchainaddressid)
                    .HasName("index_peopleblockchainuserid");

                entity.Property(e => e.Userblockchainaddressid).HasColumnName("userblockchainaddressid");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.Blockchainentityid).HasColumnName("blockchainentityid");

                entity.Property(e => e.Blockchainprivatekey)
                    .HasColumnName("blockchainprivatekey")
                    .HasColumnType("character varying(1024)");

                entity.Property(e => e.Blockchainpublicaddress)
                    .IsRequired()
                    .HasColumnName("blockchainpublicaddress")
                    .HasColumnType("character varying(512)");

                entity.Property(e => e.Walletname)
                    .HasColumnName("walletname")
                    .HasColumnType("character varying(255)");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasColumnName("createdby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Createdon)
                    .HasColumnName("createdon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-11-28'::date");

                entity.Property(e => e.Isdefault).HasColumnName("isdefault");

                entity.Property(e => e.Modifiedby)
                    .IsRequired()
                    .HasColumnName("modifiedby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Modifiedon)
                    .HasColumnName("modifiedon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-11-28'::date");

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.HasOne(d => d.Blockchainentity)
                    .WithMany(p => p.Userblockchainaddress)
                    .HasForeignKey(d => d.Blockchainentityid)
                    .HasConstraintName("fk_userbloc_reference_blockcha");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Userblockchainaddress)
                    .HasForeignKey(d => d.Userid)
                    .HasConstraintName("fk_userbloc_reference_user");
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
                    .HasDefaultValueSql("'2018-11-28'::date");

                entity.Property(e => e.Genericattributeid).HasColumnName("genericattributeid");

                entity.Property(e => e.Modifiedby)
                    .IsRequired()
                    .HasColumnName("modifiedby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Modifiedon)
                    .HasColumnName("modifiedon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-11-28'::date");

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

            modelBuilder.Entity<Userprogrammap>(entity =>
            {
                entity.HasKey(e => e.Userprogramid);

                entity.ToTable("userprogrammap");

                entity.HasIndex(e => e.Userprogramid)
                    .HasName("idx_glxpolicy");

                entity.Property(e => e.Userprogramid).HasColumnName("userprogramid");

                entity.Property(e => e.Activate).HasColumnName("activate");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasColumnName("createdby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Createdon)
                    .HasColumnName("createdon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-11-28'::date");

                entity.Property(e => e.Modifiedby)
                    .IsRequired()
                    .HasColumnName("modifiedby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Modifiedon)
                    .HasColumnName("modifiedon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-11-28'::date");

                entity.Property(e => e.Termaccepted).HasColumnName("termaccepted");

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Userprogrammap)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_userprog_reference_user");
            });

            modelBuilder.Entity<Userverificationstatus>(entity =>
            {
                entity.ToTable("userverificationstatus");

                entity.Property(e => e.Userverificationstatusid).HasColumnName("userverificationstatusid");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasColumnName("createdby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Createdon)
                    .HasColumnName("createdon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-11-28'::date");

                entity.Property(e => e.Description)
                    .IsRequired()
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
                    .HasDefaultValueSql("'2018-11-28'::date");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("character varying(50)");
            });

            modelBuilder.Entity<Workflowcontainer>(entity =>
            {
                entity.ToTable("workflowcontainer");

                entity.Property(e => e.Workflowcontainerid).HasColumnName("workflowcontainerid");

                entity.Property(e => e.Body).HasColumnName("body");

                entity.Property(e => e.Categoryid).HasColumnName("categoryid");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasColumnName("createdby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Createdon)
                    .HasColumnName("createdon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-11-28'::date");

                entity.Property(e => e.Cultureid).HasColumnName("cultureid");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("character varying(1024)");

                entity.Property(e => e.Hasarguments).HasColumnName("hasarguments");

                entity.Property(e => e.Iscomponent).HasColumnName("iscomponent");

                entity.Property(e => e.Isentrypoint).HasColumnName("isentrypoint");

                entity.Property(e => e.Modifiedby)
                    .IsRequired()
                    .HasColumnName("modifiedby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Modifiedon)
                    .HasColumnName("modifiedon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-11-28'::date");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("character varying(255)");

                entity.Property(e => e.Workflowtypeid).HasColumnName("workflowtypeid");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Workflowcontainer)
                    .HasForeignKey(d => d.Categoryid)
                    .HasConstraintName("fk_workflow_fk_catego_category");

                entity.HasOne(d => d.Workflowtype)
                    .WithMany(p => p.Workflowcontainer)
                    .HasForeignKey(d => d.Workflowtypeid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_workflow_fk_workfl_workflow");
            });

            modelBuilder.Entity<Workflowgenericattributemap>(entity =>
            {
                entity.HasKey(e => e.Workflowgenericattributeid);

                entity.ToTable("workflowgenericattributemap");

                entity.Property(e => e.Workflowgenericattributeid).HasColumnName("workflowgenericattributeid");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasColumnName("createdby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Createdon)
                    .HasColumnName("createdon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-11-28'::date");

                entity.Property(e => e.Genericattributeid).HasColumnName("genericattributeid");

                entity.Property(e => e.Modifiedby)
                    .IsRequired()
                    .HasColumnName("modifiedby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Modifiedon)
                    .HasColumnName("modifiedon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-11-28'::date");

                entity.Property(e => e.Workflowcontainerid).HasColumnName("workflowcontainerid");

                entity.HasOne(d => d.Genericattribute)
                    .WithMany(p => p.Workflowgenericattributemap)
                    .HasForeignKey(d => d.Genericattributeid)
                    .HasConstraintName("fk_workflow_reference_generica");

                entity.HasOne(d => d.Workflowcontainer)
                    .WithMany(p => p.Workflowgenericattributemap)
                    .HasForeignKey(d => d.Workflowcontainerid)
                    .HasConstraintName("fk_workflow_reference_workflow");
            });

            modelBuilder.Entity<Workflowtype>(entity =>
            {
                entity.ToTable("workflowtype");

                entity.Property(e => e.Workflowtypeid).HasColumnName("workflowtypeid");

                entity.Property(e => e.Categoryid).HasColumnName("categoryid");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasColumnName("createdby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Createdon)
                    .HasColumnName("createdon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-11-28'::date");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("character varying(512)");

                entity.Property(e => e.Modifiedby)
                    .IsRequired()
                    .HasColumnName("modifiedby")
                    .HasColumnType("character varying(255)")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Modifiedon)
                    .HasColumnName("modifiedon")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-11-28'::date");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("character varying(255)");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Workflowtype)
                    .HasForeignKey(d => d.Categoryid)
                    .HasConstraintName("fk_workflow_reference_category");
            });

            modelBuilder.HasSequence<int>("bankaccountverificationstatus_bankaccountverificationstatus_seq");
        }
    }
}
