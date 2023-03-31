﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using PhotoHome.Models.Entity;

namespace PhotoHome.Models.Configurations
{
	public class ImageConfiguration : IEntityTypeConfiguration<Picture>
	{
		public int Index { get; set; } = 1;

		public void Configure(EntityTypeBuilder<Picture> builder)
		{
			Random rnd = new();

			//
			builder.HasData(new Picture { Id = Index++, Title = "A young Farahi girl stares into the camera at a local returnee and refugee village", ImageUrl = "https://images.rawpixel.com/image_social_landscape/czNmcy1wcml2YXRlL3Jhd3BpeGVsX2ltYWdlcy93ZWJzaXRlX2NvbnRlbnQvbHIvZmw4NDY3ODk0ODMzLWltYWdlLWtwMmVuZmFtLWtwMmY2aGNhLWt6ZWt5OW5lLmpwZw.jpg", LikeCount = 24, Allow = true, DownloadCount = 24, UserId = rnd.Next(1, 2).ToString() });
			builder.HasData(new Picture { Id = Index++, Title = "A boy with his mother brother in an IDP camp near the town of Jowhar, Somalia", ImageUrl = "https://images.rawpixel.com/image_social_landscape/cHJpdmF0ZS9zdGF0aWMvZmlsZXMvd2Vic2l0ZS8yMDIyLTExL2ZsMTQ4MDAzMTE1MDQtaW1hZ2UuanBn.jpg", LikeCount = 24, Allow = true, DownloadCount = 24, UserId = rnd.Next(1, 2).ToString() });
			builder.HasData(new Picture { Id = Index++, Title = "Somali woman holds her malnourished child fitted with a nasogastric tube inside a ward dedicated for diarrhea patients at the Banadir hospital in Somalia's capital Mogadishu", ImageUrl = "https://images.rawpixel.com/image_social_landscape/czNmcy1wcml2YXRlL3Jhd3BpeGVsX2ltYWdlcy93ZWJzaXRlX2NvbnRlbnQvbHIvZmwzMzM0MjEyNzU4NS1pbWFnZS1rcHFvcjdhay5qcGc.jpg", LikeCount = 24, Allow = true, DownloadCount = 24, UserId = rnd.Next(1, 2).ToString() });
			builder.HasData(new Picture { Id = Index++, Title = "Students at Nyanzwa Primary School in Iringa region, Tanzania", ImageUrl = "https://images.rawpixel.com/image_social_landscape/czNmcy1wcml2YXRlL3Jhd3BpeGVsX2ltYWdlcy93ZWJzaXRlX2NvbnRlbnQvZmw1NzYyNTE5OTE0LWltYWdlLWt1Y2cxdmRqLmpwZw.jpg", LikeCount = 24, Allow = true, DownloadCount = 24, UserId = rnd.Next(1, 2).ToString() });
			builder.HasData(new Picture { Id = Index++, Title = "Unemployed homeless beggar", ImageUrl = "https://images.rawpixel.com/image_social_landscape/czNmcy1wcml2YXRlL3Jhd3BpeGVsX2ltYWdlcy93ZWJzaXRlX2NvbnRlbnQvbHIvay0yMDEtZXllLTAwMTIzLmpwZw.jpg", LikeCount = 24, Allow = true, DownloadCount = 24, UserId = rnd.Next(1, 2).ToString() });
			builder.HasData(new Picture { Id = Index++, Title = "Women fishing in tuna industries", ImageUrl = "https://images.rawpixel.com/image_social_landscape/czNmcy1wcml2YXRlL3Jhd3BpeGVsX2ltYWdlcy93ZWJzaXRlX2NvbnRlbnQvbHIvZnJmaXNoaW5nX3dvbWVuX25lcGFsX3JpdmVyLWltYWdlLWt5Y2gxN2d1LmpwZw.jpg", LikeCount = 24, Allow = true, DownloadCount = 24, UserId = rnd.Next(1, 2).ToString() });
			builder.HasData(new Picture { Id = Index++, Title = "Marines purify water in Africa", ImageUrl = "https://images.rawpixel.com/image_social_landscape/cHJpdmF0ZS9sci9pbWFnZXMvd2Vic2l0ZS8yMDIyLTA0L2ZsNDg0NDM2MDQxNC1pbWFnZS1rcWFwcDR0eC5qcGc.jpg", LikeCount = 24, Allow = true, DownloadCount = 24, UserId = rnd.Next(1, 2).ToString() });
			builder.HasData(new Picture { Id = Index++, Title = "Ghana students chat with each other", ImageUrl = "https://images.rawpixel.com/image_social_landscape/cHJpdmF0ZS9zdGF0aWMvZmlsZXMvd2Vic2l0ZS8yMDIyLTExL2ZsMTI3OTU3MDgyMjMtaW1hZ2UuanBn.jpg", LikeCount = 24, Allow = true, DownloadCount = 24, UserId = rnd.Next(1, 2).ToString() });
			builder.HasData(new Picture { Id = Index++, Title = "Indigenous senior Indian man looking at the camera", ImageUrl = "https://images.rawpixel.com/image_social_landscape/czNmcy1wcml2YXRlL3Jhd3BpeGVsX2ltYWdlcy93ZWJzaXRlX2NvbnRlbnQvbHIvaW4tbS01MjA3LmpwZw.jpg?s=aQ9OjMGSpUawxXFjZgWZ0K4H6EcDmrXXiAjdX0VTf5E", LikeCount = 24, Allow = true, DownloadCount = 24, UserId = rnd.Next(1, 2).ToString() });
			builder.HasData(new Picture { Id = Index++, Title = "Old weathered house with mountain range in the background", ImageUrl = "https://images.rawpixel.com/image_social_landscape/czNmcy1wcml2YXRlL3Jhd3BpeGVsX2ltYWdlcy93ZWJzaXRlX2NvbnRlbnQvbHIvay1tby1rYXpha2hvdXNlLmpwZw.jpg", LikeCount = 24, Allow = true, DownloadCount = 24, UserId = rnd.Next(1, 2).ToString() });
			builder.HasData(new Picture { Id = Index++, Title = "A young Somali girl walks through a market in Merca", ImageUrl = "https://images.rawpixel.com/image_social_landscape/czNmcy1wcml2YXRlL3Jhd3BpeGVsX2ltYWdlcy93ZWJzaXRlX2NvbnRlbnQvbHIvZmw4NDYwMTQzMjMzLWltYWdlLWtwcW9nNnNiLmpwZw.jpg", LikeCount = 24, Allow = true, DownloadCount = 24, UserId = rnd.Next(1, 2).ToString() });
			builder.HasData(new Picture { Id = Index++, Title = "Children wait in line for a humanitarian meal in Port-au-Prince, Haiti", ImageUrl = "https://images.rawpixel.com/image_social_landscape/czNmcy1wcml2YXRlL3Jhd3BpeGVsX2ltYWdlcy93ZWJzaXRlX2NvbnRlbnQvbHIvZmw0Mjg1NjU1NDczLWltYWdlLWtwMmVwMWNjLWt6ZWt5YWk0LmpwZw.jpg", LikeCount = 24, Allow = true, DownloadCount = 24, UserId = rnd.Next(1, 2).ToString() });
			builder.HasData(new Picture { Id = Index++, Title = "Homeless guy on the street", ImageUrl = "https://images.rawpixel.com/image_social_landscape/czNmcy1wcml2YXRlL3Jhd3BpeGVsX2ltYWdlcy93ZWJzaXRlX2NvbnRlbnQvbHIvay0yMDEtdGVkZHktMDA4OS5qcGc.jpg", LikeCount = 24, Allow = true, DownloadCount = 24, UserId = rnd.Next(1, 2).ToString() });
			builder.HasData(new Picture { Id = Index++, Title = "Homeless guy sleeping on the street", ImageUrl = "https://images.rawpixel.com/image_social_landscape/czNmcy1wcml2YXRlL3Jhd3BpeGVsX2ltYWdlcy93ZWJzaXRlX2NvbnRlbnQvbHIvay0yMDEtZXllLWFlLTAwODIxLmpwZw.jpg", LikeCount = 24, Allow = true, DownloadCount = 24, UserId = rnd.Next(1, 2).ToString() });
			builder.HasData(new Picture { Id = Index++, Title = "A young Somali girl looks out of a tent at an IDP camp near the town of Jowhar, Somalia", ImageUrl = "https://images.rawpixel.com/image_social_landscape/czNmcy1wcml2YXRlL3Jhd3BpeGVsX2ltYWdlcy93ZWJzaXRlX2NvbnRlbnQvbHIvZmwxMTQwMTY4NjcwNC1pbWFnZS1rcHFvbGZtZi1remVtZmM5ZC5qcGc.jpg", LikeCount = 24, Allow = true, DownloadCount = 24, UserId = rnd.Next(1, 2).ToString() });
			builder.HasData(new Picture { Id = Index++, Title = "A girl holds her young sister in a camp during a bore hole handing over ceremony in Kismayo, Somalia", ImageUrl = "https://images.rawpixel.com/image_social_landscape/czNmcy1wcml2YXRlL3Jhd3BpeGVsX2ltYWdlcy93ZWJzaXRlX2NvbnRlbnQvbHIvZmwxNTM1OTI0NTIwNC1pbWFnZS1rcHFvaXNuNC5qcGc.jpg", LikeCount = 24, Allow = true, DownloadCount = 24, UserId = rnd.Next(1, 2).ToString() });
			builder.HasData(new Picture { Id = Index++, Title = "Make shift houses in Internal Displaced Camp outside of Beled weyne Capital of Hiran Region, Somalia", ImageUrl = "https://images.rawpixel.com/image_social_landscape/cHJpdmF0ZS9sci9pbWFnZXMvd2Vic2l0ZS8yMDIyLTA1L2ZsMTUxMDQ0ODUyODMtaW1hZ2Uta3Bxb2R4bnkuanBn.jpg", LikeCount = 24, Allow = true, DownloadCount = 24, UserId = rnd.Next(1, 2).ToString() });
			builder.HasData(new Picture { Id = Index++, Title = "Cambodian boy fishing in the river", ImageUrl = "https://images.rawpixel.com/image_social_landscape/czNmcy1wcml2YXRlL3Jhd3BpeGVsX2ltYWdlcy93ZWJzaXRlX2NvbnRlbnQvay1jYS1maXNoaW5nYm95MzIuanBn.jpg", LikeCount = 24, Allow = true, DownloadCount = 24, UserId = rnd.Next(1, 2).ToString() });
			builder.HasData(new Picture { Id = Index++, Title = "A young Somali girl waits inside a tent for free medical check-ups and treatment in the Kaaran district, Somalia", ImageUrl = "https://images.rawpixel.com/image_social_landscape/cHJpdmF0ZS9sci9pbWFnZXMvd2Vic2l0ZS8yMDIyLTA1L2ZsNjg0MDU5OTM5My1pbWFnZS1rcHFvaG4wcC5qcGc.jpg", LikeCount = 24, Allow = true, DownloadCount = 24, UserId = rnd.Next(1, 2).ToString() });
			builder.HasData(new Picture { Id = Index++, Title = "A woman and her children wait to receive food at an Internally Displaced Persons camp at Doolow, Gedo region, Somalia", ImageUrl = "https://images.rawpixel.com/image_social_landscape/cHJpdmF0ZS9sci9pbWFnZXMvd2Vic2l0ZS8yMDIyLTA0L2ZsMzUxNDUyNTM2MTEtaW1hZ2Uta3VkaTM1cGwuanBn.jpg", LikeCount = 24, Allow = true, DownloadCount = 24, UserId = rnd.Next(1, 2).ToString() });
			builder.HasData(new Picture { Id = Index++, Title = "A woman holds a young child while they wait to enter a free medical clinic in Somalia", ImageUrl = "https://images.rawpixel.com/image_social_landscape/cHJpdmF0ZS9sci9pbWFnZXMvd2Vic2l0ZS8yMDIyLTA0L2ZsMTA0MTg5MjQ1NjYtaW1hZ2Uta3Bxb3RtZDQuanBn.jpg", LikeCount = 24, Allow = true, DownloadCount = 24, UserId = rnd.Next(1, 2).ToString() });
			builder.HasData(new Picture { Id = Index++, Title = "A girl stands in an IDP camp on the outskirts of Belet Weyne, Somalia", ImageUrl = "https://images.rawpixel.com/image_social_landscape/czNmcy1wcml2YXRlL3Jhd3BpeGVsX2ltYWdlcy93ZWJzaXRlX2NvbnRlbnQvbHIvZmw4NTQzODQxODczLWltYWdlLWtwcW9mc2poLWt6ZWt5OWZiLmpwZw.jpg", LikeCount = 24, Allow = true, DownloadCount = 24, UserId = rnd.Next(1, 2).ToString() });
			builder.HasData(new Picture { Id = Index++, Title = "A woman sits in an IDP camp on the outskirts of Belet Weyne, Somalia", ImageUrl = "https://images.rawpixel.com/image_social_landscape/czNmcy1wcml2YXRlL3Jhd3BpeGVsX2ltYWdlcy93ZWJzaXRlX2NvbnRlbnQvbHIvZmw4NTQzODQwNTQ5LWltYWdlLWtwcW9mdXpnLmpwZw.jpg", LikeCount = 24, Allow = true, DownloadCount = 24, UserId = rnd.Next(1, 2).ToString() });
			builder.HasData(new Picture { Id = Index++, Title = "An infant diagnosed with having a Guinea worm disease (GWD)", ImageUrl = "https://images.rawpixel.com/image_social_landscape/czNmcy1wcml2YXRlL3Jhd3BpeGVsX2ltYWdlcy93ZWJzaXRlX2NvbnRlbnQvbHIvcGQ1OGJhdGNoMS0xOTM1OV8xLmpwZw.jpg", LikeCount = 24, Allow = true, DownloadCount = 24, UserId = rnd.Next(1, 2).ToString() });
			builder.HasData(new Picture { Id = Index++, Title = "Afghan children stand next to their father", ImageUrl = "https://images.rawpixel.com/image_social_landscape/cHJpdmF0ZS9sci9pbWFnZXMvd2Vic2l0ZS8yMDIyLTA0L2ZsNDUxODgzODMxNC1pbWFnZS1rcWFtNTgxMy5qcGc.jpg", LikeCount = 24, Allow = true, DownloadCount = 24, UserId = rnd.Next(1, 2).ToString() });
			builder.HasData(new Picture { Id = Index++, Title = "Children Living in a Camp Between Weedpatch and Lamont, Kern County, California", ImageUrl = "https://images.rawpixel.com/image_social_landscape/cHJpdmF0ZS9sci9pbWFnZXMvd2Vic2l0ZS8yMDIzLTAzL2ZsMzY3OTUwMjg0Ni1pbWFnZS5qcGc.jpg", LikeCount = 24, Allow = true, DownloadCount = 24, UserId = rnd.Next(1, 2).ToString() });
			builder.HasData(new Picture { Id = Index++, Title = "A woman waits in the shade of a derelict building to see a doctor at a free medical clinic in Somalia", ImageUrl = "https://images.rawpixel.com/image_social_landscape/cHJpdmF0ZS9sci9pbWFnZXMvd2Vic2l0ZS8yMDIyLTA0L2ZsOTY1Mjg5MTQyNC1pbWFnZS1rcHFvdTN2ay5qcGc.jpg", LikeCount = 24, Allow = true, DownloadCount = 24, UserId = rnd.Next(1, 2).ToString() });
			builder.HasData(new Picture { Id = Index++, Title = "Cambodian boy by the river", ImageUrl = "https://images.rawpixel.com/image_social_landscape/czNmcy1wcml2YXRlL3Jhd3BpeGVsX2ltYWdlcy93ZWJzaXRlX2NvbnRlbnQvbHIvay1jYS1maXNoaW5nYm95My1idy5qcGc.jpg", LikeCount = 24, Allow = true, DownloadCount = 24, UserId = rnd.Next(1, 2).ToString() });
			builder.HasData(new Picture { Id = Index++, Title = "Cute Asian children smiling at the camera", ImageUrl = "https://images.rawpixel.com/image_social_landscape/cHJpdmF0ZS9zdGF0aWMvaW1hZ2Uvd2Vic2l0ZS8yMDIyLTA0L2xyL2ZydW5zcGxhc2gxNTEyNi1pbWFnZS1rejJlNmo5bC5qcGc.jpg", LikeCount = 24, Allow = true, DownloadCount = 24, UserId = rnd.Next(1, 2).ToString() });
			builder.HasData(new Picture { Id = Index++, Title = "Homeless woman", ImageUrl = "https://images.rawpixel.com/image_social_landscape/czNmcy1wcml2YXRlL3Jhd3BpeGVsX2ltYWdlcy93ZWJzaXRlX2NvbnRlbnQvbHIvay0yMDEtZXllLTAwMDQxLmpwZw.jpg", LikeCount = 24, Allow = true, DownloadCount = 24, UserId = rnd.Next(1, 2).ToString() });
			builder.HasData(new Picture { Id = Index++, Title = "Mothers with their children stand in front of their makeshift houses at Maqori Manyow Camp", ImageUrl = "https://images.rawpixel.com/image_social_landscape/cHJpdmF0ZS9sci9pbWFnZXMvd2Vic2l0ZS8yMDIyLTA0L2ZsMzQzOTA1ODg2NDUtaW1hZ2Uta3VkaTNkbGMuanBn.jpg", LikeCount = 24, Allow = true, DownloadCount = 24, UserId = rnd.Next(1, 2).ToString() });
			builder.HasData(new Picture { Id = Index++, Title = "Homeless beggar", ImageUrl = "https://images.rawpixel.com/image_social_landscape/czNmcy1wcml2YXRlL3Jhd3BpeGVsX2ltYWdlcy93ZWJzaXRlX2NvbnRlbnQvbHIvcHgxMjk5MzktaW1hZ2Uta3d5cXMwdjcuanBn.jpg", LikeCount = 24, Allow = true, DownloadCount = 24, UserId = rnd.Next(1, 2).ToString() });
			builder.HasData(new Picture { Id = Index++, Title = "Free homeless eating rice", ImageUrl = "https://images.rawpixel.com/image_social_landscape/czNmcy1wcml2YXRlL3Jhd3BpeGVsX2ltYWdlcy93ZWJzaXRlX2NvbnRlbnQvbHIvcHg1NTk1NTQtaW1hZ2Uta3d2dmZoeHEuanBn.jpg", LikeCount = 24, Allow = true, DownloadCount = 24, UserId = rnd.Next(1, 2).ToString() });
			builder.HasData(new Picture { Id = Index++, Title = "A girl stands in an IDP camp on the outskirts of Belet Weyne, Somalia", ImageUrl = "https://images.rawpixel.com/image_social_landscape/cHJpdmF0ZS9sci9pbWFnZXMvd2Vic2l0ZS8yMDIyLTA1L2ZsODU0Mzg0MDk3My1pbWFnZS1rcHFvZnE2Yi5qcGc.jpg", LikeCount = 24, Allow = true, DownloadCount = 24, UserId = rnd.Next(1, 2).ToString() });
			builder.HasData(new Picture { Id = Index++, Title = "Mohammed, suffering from Malaria, recovers at a Burundian run clinic in Somalia", ImageUrl = "https://images.rawpixel.com/image_social_landscape/cHJpdmF0ZS9sci9pbWFnZXMvd2Vic2l0ZS8yMDIyLTA0L2ZsODY1NDczODY2OC1pbWFnZS1rcHFvdmh2Yy5qcGc.jpg", LikeCount = 24, Allow = true, DownloadCount = 24, UserId = rnd.Next(1, 2).ToString() });
			builder.HasData(new Picture { Id = Index++, Title = "Homesteads within the Howlwadaag Internally Displaced Persons (IDPs) camp in Baidoa, Somalia", ImageUrl = "https://images.rawpixel.com/image_social_landscape/czNmcy1wcml2YXRlL3Jhd3BpeGVsX2ltYWdlcy93ZWJzaXRlX2NvbnRlbnQvbHIvZmw0Nzc1MTAyMzEyMS1pbWFnZS1rdWY3NzF4ei5qcGc.jpg", LikeCount = 24, Allow = true, DownloadCount = 24, UserId = rnd.Next(1, 2).ToString() });
			builder.HasData(new Picture { Id = Index++, Title = "Musahar children in town, Sauraha, Chitwan District, Nepal", ImageUrl = "https://images.rawpixel.com/image_social_landscape/czNmcy1wcml2YXRlL3Jhd3BpeGVsX2ltYWdlcy93ZWJzaXRlX2NvbnRlbnQvbHIvZmw0MDI1NjYyNzM4Mi1pbWFnZS1rencyYnRkMi5qcGc.jpg", LikeCount = 24, Allow = true, DownloadCount = 24, UserId = rnd.Next(1, 2).ToString() });
			builder.HasData(new Picture { Id = Index++, Title = "Pakistanis rush to pick up supplies from Marines", ImageUrl = "https://images.rawpixel.com/image_social_landscape/czNmcy1wcml2YXRlL3Jhd3BpeGVsX2ltYWdlcy93ZWJzaXRlX2NvbnRlbnQvZmw0OTY3Mjg0MjI1LWltYWdlLWtxYnNyNDV1LmpwZw.jpg", LikeCount = 24, Allow = true, DownloadCount = 24, UserId = rnd.Next(1, 2).ToString() });
			builder.HasData(new Picture { Id = Index++, Title = "Afghan child sits with her little sister", ImageUrl = "https://images.rawpixel.com/image_social_landscape/cHJpdmF0ZS9sci9pbWFnZXMvd2Vic2l0ZS8yMDIyLTA0L2ZsNDUxODgzODg0Ni1pbWFnZS1rcWFtNWc0ay5qcGc.jpg", LikeCount = 24, Allow = true, DownloadCount = 24, UserId = rnd.Next(1, 2).ToString() });
			builder.HasData(new Picture { Id = Index++, Title = "Marines help keep children healthy", ImageUrl = "https://images.rawpixel.com/image_social_landscape/czNmcy1wcml2YXRlL3Jhd3BpeGVsX2ltYWdlcy93ZWJzaXRlX2NvbnRlbnQvbHIvZmw1Mzg0Njk0OTAyLWltYWdlLWtxYW0zbXpoLmpwZw.jpg", LikeCount = 24, Allow = true, DownloadCount = 24, UserId = rnd.Next(1, 2).ToString() });
			builder.HasData(new Picture { Id = Index++, Title = "Marines hard at work", ImageUrl = "https://images.rawpixel.com/image_social_landscape/czNmcy1wcml2YXRlL3Jhd3BpeGVsX2ltYWdlcy93ZWJzaXRlX2NvbnRlbnQvZmw1MDgwNjQwMzY3LWltYWdlLWtxYXBveHhoLmpwZw.jpg", LikeCount = 24, Allow = true, DownloadCount = 24, UserId = rnd.Next(1, 2).ToString() });
			builder.HasData(new Picture { Id = Index++, Title = "A young boy poses for the camera as Burundian troops, part of the African Union Mission in Somalia", ImageUrl = "https://images.rawpixel.com/image_social_landscape/cHJpdmF0ZS9sci9pbWFnZXMvd2Vic2l0ZS8yMDIyLTA0L2ZsMjU0Nzg0NjkxNDUtaW1hZ2Uta3Bxb241aXguanBn.jpg", LikeCount = 24, Allow = true, DownloadCount = 24, UserId = rnd.Next(1, 2).ToString() });
			builder.HasData(new Picture { Id = Index++, Title = "The United Nations has been providing clean water, food and non-food emergency supplies to families displaced by floods at Ceel Jaale IDP camp in Belet Weyne, Somalia", ImageUrl = "https://images.rawpixel.com/image_social_landscape/cHJpdmF0ZS9sci9pbWFnZXMvd2Vic2l0ZS8yMDIyLTA0L2ZsNDk5NDkxNjE4NDctaW1hZ2Uta3VkaTNkcnEuanBn.jpg", LikeCount = 24, Allow = true, DownloadCount = 24, UserId = rnd.Next(1, 2).ToString() });
		}
	}
}