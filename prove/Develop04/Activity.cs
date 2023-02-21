public class Activity {
    private string _activityName;
    private string _description;
    private float _duration;

    public Activity(string activityName, string description, float duration) {
        _activityName = activityName;
        _description = description;
        _duration = duration;
    }

    public string GetActivityName(){
        return _activityName;
    }
    public string GetDescription(){
        return _description;
    }
    public float GetDuration(){
        return _duration;
    }
}