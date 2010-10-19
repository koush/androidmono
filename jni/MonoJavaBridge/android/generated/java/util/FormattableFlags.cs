namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class FormattableFlags : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static FormattableFlags()
		{
			InitJNI();
		}
		protected FormattableFlags(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public static int LEFT_JUSTIFY
		{
			get
			{
				return 1;
			}
		}
		public static int UPPERCASE
		{
			get
			{
				return 2;
			}
		}
		public static int ALTERNATE
		{
			get
			{
				return 4;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.FormattableFlags.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/FormattableFlags"));
		}
	}
}
