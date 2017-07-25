using System.Collections.Generic;

namespace FacebookApi.Utilities
{
    public static class ApiUtilities
    {
        public static IList<string> GetCampaignApiFieldSelectors()
        {
            var apiSelectors = new List<string>()
            {
                "id",
                "account_id",
                "adlabels",
                "buying_type",
                "can_use_spend_cap",
                "configured_status",
                "created_time",
                "effective_status",
                "name",
                "objective",
                "recommendations",
                "spend_cap",
                "start_time",
                "status",
                "stop_time",
                "updated_time"
            };
            return apiSelectors;
        }

        public static IList<string> GetAdsetApiFieldSelectors(bool isIncludeCampaignFields)
        {
            var apiSelectors = new List<string>()
            {
                "account_id",
                "adlabels",
                "adset_schedule",
                "bid_amount",
                "bid_info",
                "billing_event",
                "budget_remaining",
                "campaign_id",
                "created_time",
                "configured_status",
                "creative_sequence",
                "daily_budget",
                "effective_status",
                "end_time",
                "frequency_cap_reset_period",
                "frequency_control_specs",
                "id",
                "frequency_cap",
                "is_autobid",
                "lifetime_budget",
                "lifetime_frequency_cap",
                "lifetime_imps",
                "name",
                "optimization_goal",
                "pacing_type",
                "product_ad_behavior",
                "promoted_object",
                "recommendations",
                "rf_prediction_id",
                "rtb_flag",
                "start_time",
                "status",
                "targeting",
                "updated_time"
            };


            apiSelectors.Add(isIncludeCampaignFields
                ? string.Format("campaign.fields({0})", string.Join(",", GetCampaignApiFieldSelectors()))
                : "campaign");

            return apiSelectors;
        }

        public static IList<string> GetCreativeApiFieldSelectors()
        {
            var apiSelectors = new List<string>()
            {
                "id",
                "adlabels",
                "applink_treatment",
                "body",
                "call_to_action_type",
                "effective_object_story_id",
                "image_crops",
                "image_hash",
                "image_url",
                "instagram_actor_id",
                "instagram_permalink_url",
                "instagram_story_id",
                "link_og_id",
                "link_url",
                "name",
                "object_id",
                "object_story_id",
                "object_story_spec",
                "object_type",
                "object_url",
                "platform_customizations",
                "product_set_id",
                "run_status",
                "template_url",
                "thumbnail_url",
                "title",
                "url_tags"
            };

            return apiSelectors;
        }

        public static IList<string> GetAdApiFieldSelectors(bool isIncludeCreativeFields = false,
            bool isIncludeCampaignFields = false,
            bool isIncludeAdsetFields = false)
        {
            var apiFields = new List<string>
            {
                "id",
                "account_id",
                "ad_review_feedback",
                "adlabels",
                "adset_id",
                "bid_amount",
                "bid_info",
                "bid_type",
                "campaign_id",
                "configured_status",
                "conversion_specs",
                "created_time",
                "effective_status",
                "last_updated_by_app_id",
                "name",
                "recommendations",
                "status",
                "tracking_specs",
                "updated_time"
            };

            apiFields.Add(isIncludeCampaignFields
                ? string.Format("campaign.fields({0})", string.Join(",", GetCampaignApiFieldSelectors()))
                : "campaign");

            apiFields.Add(isIncludeAdsetFields
                ? string.Format("adset.fields({0})",
                    string.Join(",", GetAdsetApiFieldSelectors(isIncludeCampaignFields)))
                : "adset");

            apiFields.Add(isIncludeCreativeFields
                ? string.Format("creative.fields({0})", string.Join(",", GetCreativeApiFieldSelectors()))
                : "creative");

            return apiFields;
        }


        public static IList<string> GetPostApiFieldSelectors()
        {
            var apiSelectors = new List<string>()
            {
                "id",
                "admin_creator",
                "application",
                "call_to_action",
                "caption",
                "created_time",
                "description",
                "feed_targeting",
                "from",
                "icon",
                "is_hidden",
                "is_published",
                "link",
                "message",
                "message_tags",
                "name",
                "object_id",
                "picture",
                "place",
                "privacy",
                "properties",
                "shares",
                "source",
                "status_type",
                "story",
                "story_tags",
                "targeting",
                "to",
                "type",
                "updated_time",
                "with_tags"
            };

            return apiSelectors;
        }
    }
}
