namespace android.net
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ParseException : java.lang.RuntimeException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ParseException()
		{
			InitJNI();
		}
		protected ParseException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.FieldId _response5234;
		public global::java.lang.String response
		{
			get
			{
				return default(global::java.lang.String);
			}
			set
			{
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.net.ParseException.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/net/ParseException"));
		}
	}
}
