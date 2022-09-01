using Lab2_Images.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Lab2_Images.EntityConfiguration
{
    public class ImageConfiguration : IEntityTypeConfiguration<Images>
    {
        public void Configure(EntityTypeBuilder<Images> builder)
        {
            builder.HasKey(i => i.Id);

            builder.HasData(
                new List<Images>
                {
                    new Images
                    {
                        Id = 1,
                        ImageUrl =
                            "https://images.unsplash.com/photo-1556477631-78689fffc8f0?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=689&q=80"
                    },
                    new Images
                    {
                        Id = 2,
                        ImageUrl =
                            "https://images.unsplash.com/photo-1525095182007-3874c4e2b38b?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=687&q=80"
                    },
                    new Images
                    {
                        Id = 3,
                        ImageUrl =
                            "https://images.unsplash.com/photo-1517586979036-b7d1e86b3345?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=688&q=80"
                    },
                    new Images
                    {
                        Id = 4,
                        ImageUrl =
                            "https://images.unsplash.com/photo-1540206351-a5b7c9efe478?ixlib=rb-1.2.1&ixid=MnwxMjA3fDF8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=687&q=80"
                    },
                    new Images
                    {
                        Id = 5,
                        ImageUrl =
                            "https://images.unsplash.com/photo-1661804354022-435bb8c16c9f?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=687&q=80"
                    },
                    new Images
                    {
                        Id = 6,
                        ImageUrl =
                            "https://images.unsplash.com/photo-1661829454644-3cbcf38f823d?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=687&q=80"
                    },
                    new Images
                    {
                        Id = 7,
                        ImageUrl =
                            "https://images.unsplash.com/photo-1657299170111-371dabe2e60d?ixlib=rb-1.2.1&ixid=MnwxMjA3fDF8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=687&q=80"
                    },
                    new Images
                    {
                        Id = 8,
                        ImageUrl =
                            "https://images.unsplash.com/photo-1657299143549-73fb118d68aa?ixlib=rb-1.2.1&ixid=MnwxMjA3fDF8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=687&q=80"
                    },
                    new Images
                    {
                        Id = 9,
                        ImageUrl =
                            "https://images.unsplash.com/photo-1661704107314-b603320832be?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=687&q=80"
                    },
                    new Images
                    {
                        Id = 10,
                        ImageUrl =
                            "https://images.unsplash.com/photo-1661698048572-95812cdcf44b?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=687&q=80"
                    },
                }
            );
        }
    }
}
