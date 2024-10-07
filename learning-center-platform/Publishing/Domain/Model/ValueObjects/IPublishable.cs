namespace learning_center_platform.Publishing.Domain.Model.ValueObjects;

public interface IPublishable
{
    void SendToEdit();
    void SendToApproval();
    void ApproveAndLock();
    void Reject();
    void ReturnToEdit();
    
}