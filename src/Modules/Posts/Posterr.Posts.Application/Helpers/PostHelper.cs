using Posterr.Posts.Application.InputModels;
using Posterr.Shared.Core.Entities;
using Posterr.Shared.Core.Enums;

namespace Posterr.Posts.Application.Helpers
{
    public static class PostHelper
    {
        public static bool CanPost(this CreatePostInputModel postModel,  Post originalPost)
        {
            switch (postModel.PostType)
            {
                case PostType.OriginalPost:
                    return true;
                case PostType.Repost:
                    return originalPost.PostType == PostType.OriginalPost || originalPost.PostType == PostType.QuotePost ? true : false;
                case PostType.QuotePost:
                    return originalPost.PostType == PostType.OriginalPost || originalPost.PostType == PostType.Repost ? true : false;
                default:
                    return false;
            }
        }
    }
}
