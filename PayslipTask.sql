CREATE TABLE [dbo].[tbl_MasterTaxSlabs](
	[TaxId] [int] IDENTITY(1,1) NOT NULL,
	[SlabStart] [int] NULL,
	[SlabEnd] [int] NULL,
	[CentPerDollar] [float] NULL,
	[Fix] [int] NULL
) ON [PRIMARY]

GO



Insert into tbl_mastertaxslabs (SlabStart,SlabEnd,CentPerDollar,Fix) Values(0,18200,null,0);
Insert into tbl_mastertaxslabs (SlabStart,SlabEnd,CentPerDollar,Fix) Values(18201,37000,0.19,0);
Insert into tbl_mastertaxslabs (SlabStart,SlabEnd,CentPerDollar,Fix) Values(37001,87000,0.325,3572);
Insert into tbl_mastertaxslabs (SlabStart,SlabEnd,CentPerDollar,Fix) Values(87001,180000,0.37,19822);
Insert into tbl_mastertaxslabs (SlabStart,SlabEnd,CentPerDollar,Fix) Values(180001,null,0.45,19822);



Create Procedure CreatePayslip
(
		@Fname varchar(50),
		@Lname varchar(50),
		@AnnualSalary int,
		@SuperRate float,
		@PayStartDate varchar(50)
)
	AS
BEGIN
			Declare @PreviousSlab int,@CheckIncomeTax int,@GrossIncome int
			Select @PreviousSlab= max(slabend) from tbl_mastertaxslabs where @AnnualSalary >slabend
			Select @GrossIncome=@AnnualSalary/12 
			Select @CheckIncomeTax= CEILING(fix+(@AnnualSalary-@PreviousSlab)*centperdollar)/12  from tbl_mastertaxslabs
			where @AnnualSalary between slabstart and slabend;

			Select @Fname+@Lname as Name,
			@PayStartDate as PayPeriod,
			@GrossIncome GrossIncome,
			@CheckIncomeTax As IncomeTax,
			@GrossIncome-@CheckIncomeTax as NetIncome, 
		   Cast(FLOOR((@AnnualSalary*@SuperRate)/100)/12  as int) as SuperAmount
end

--Exec CreatePayslip 'Andrew','Smith',60050,9,'01 March-31 March'

--Exec CreatePayslip 'Claire', 'Wong', 120000, 10 , '01 March – 31 March'


