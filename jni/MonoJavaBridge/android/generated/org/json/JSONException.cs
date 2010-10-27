namespace org.json
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class JSONException : java.lang.Exception
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static JSONException()
		{
			InitJNI();
		}
		protected JSONException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _JSONException34079;
		public JSONException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.json.JSONException.staticClass, global::org.json.JSONException._JSONException34079, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.json.JSONException.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/json/JSONException"));
			global::org.json.JSONException._JSONException34079 = @__env.GetMethodIDNoThrow(global::org.json.JSONException.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
