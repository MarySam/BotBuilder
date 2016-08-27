// Code generated by Microsoft (R) AutoRest Code Generator 0.13.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Bot.Connector
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    

    /// <summary>
    /// Conversations operations.
    /// </summary>
    public partial interface IConversations
    {
        /// <summary>
        /// CreateConversation
        /// </summary>
        /// Create a new Conversation.
        /// 
        /// POST to this method with a
        /// * Bot being the bot creating the conversation
        /// * IsGroup set to true if this is not a direct message (default is
        /// false)
        /// * Members array contining the members you want to have be in the
        /// conversation.
        /// 
        /// The return value is a ResourceResponse which contains a
        /// conversation id which is suitable for use
        /// in the message payload and REST API uris.
        /// 
        /// Most channels only support the semantics of bots initiating a
        /// direct message conversation.  An example of how to do that would
        /// be:
        /// 
        /// ```
        /// var resource = await
        /// connector.conversations.CreateConversation(new ConversationParameters(){
        /// Bot = bot, members = new ChannelAccount[] { new
        /// ChannelAccount("user1") } );
        /// await connect.Conversations.SendToConversationAsync(resource.Id,
        /// new Activity() ... ) ;
        /// 
        /// ```
        /// <param name='parameters'>
        /// Parameters to create the conversation from
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<object>> CreateConversationWithHttpMessagesAsync(ConversationParameters parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// SendToConversation
        /// </summary>
        /// This method allows you to send an activity to a conversation
        /// regardless of previous posts to a conversation.
        /// 
        /// This is slightly different then ReplyToConversation().
        /// * SendToConverstion(conversationId) - will simply append a message
        /// to the end of the conversation according to the timestamp or
        /// semantics of the channel
        /// * ReplyToConversation(conversationId,ActivityId) - models the
        /// semantics of threaded conversations, meaning it has the
        /// information necessary for the
        /// channel to reply to the actual message being responded to.
        /// 
        /// SendToConversation is appropriate for the first message which
        /// initiates a conversation, or if you don't have a particular
        /// activity you are responding to.
        /// 
        /// ReplyToConversation is preferable to SendToConversation() because
        /// it maintains threaded conversations.
        /// <param name='activity'>
        /// Activity to send
        /// </param>
        /// <param name='conversationId'>
        /// Conversation ID
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<APIResponse>> SendToConversationWithHttpMessagesAsync(Activity activity, string conversationId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// ReplyToActivity
        /// </summary>
        /// This method allows you to reply to an activity.
        /// 
        /// This is slightly different then SendToConversation().
        /// * SendToConverstion(conversationId) - will simply append a message
        /// to the end of the conversation according to the timestamp or
        /// semantics of the channel
        /// * ReplyToConversation(conversationId,ActivityId) - models the
        /// semantics of threaded conversations, meaning it has the
        /// information necessary for the
        /// channel to reply to the actual message being responded to.
        /// 
        /// ReplyToConversation is almost always preferable to
        /// SendToConversation() because it maintains threaded conversations.
        /// 
        /// SendToConversation is appropriate for the first message which
        /// initiates a conversation, or if you don't have a particular
        /// activity you are responding to.
        /// <param name='conversationId'>
        /// Conversation ID
        /// </param>
        /// <param name='activityId'>
        /// activityId the reply is to (OPTIONAL)
        /// </param>
        /// <param name='activity'>
        /// Activity to send
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<APIResponse>> ReplyToActivityWithHttpMessagesAsync(string conversationId, string activityId, Activity activity, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// GetConversationMembers
        /// </summary>
        /// Call this method to enumerate the members of a converstion.
        /// 
        /// This REST API takes a ConversationId and returns an array of
        /// ChannelAccount[] objects
        /// which are the members of the conversation.
        /// <param name='conversationId'>
        /// Conversation ID
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<object>> GetConversationMembersWithHttpMessagesAsync(string conversationId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// GetActivityMembers
        /// </summary>
        /// Call this method to enumerate the members of an activity.
        /// 
        /// This REST API takes a ConversationId and a ActivityId, returning
        /// an array of ChannelAccount[] objects
        /// which are the members of the particular activity in the
        /// conversation.
        /// <param name='conversationId'>
        /// Conversation ID
        /// </param>
        /// <param name='activityId'>
        /// Activity ID
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<object>> GetActivityMembersWithHttpMessagesAsync(string conversationId, string activityId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// UploadAttachment
        /// </summary>
        /// This method allows you to upload an attachment directly into a
        /// channels blob storage.
        /// 
        /// This is useful because it allows you to store data in a compliant
        /// store when dealing with enterprises.
        /// 
        /// The response is a ResourceResponse which contains an AttachmentId
        /// which is suitable for using with the attachments api.
        /// <param name='conversationId'>
        /// Conversation ID
        /// </param>
        /// <param name='attachmentUpload'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<object>> UploadAttachmentWithHttpMessagesAsync(string conversationId, AttachmentData attachmentUpload, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
