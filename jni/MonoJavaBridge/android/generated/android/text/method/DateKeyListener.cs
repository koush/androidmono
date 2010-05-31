namespace android.text.method
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class DateKeyListener : android.text.method.NumberKeyListener
	{
		internal new static global::java.lang.Class staticClass;
		static DateKeyListener()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.text.method.DateKeyListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.text.method.DateKeyListener(@__env);
			}
		}
		protected DateKeyListener(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _getInstance7128;
		public static global::android.text.method.DateKeyListener getInstance() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.text.method.DateKeyListener>(@__env, @__env.CallStaticObjectMethodPtr(android.text.method.DateKeyListener.staticClass, global::android.text.method.DateKeyListener._getInstance7128));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getInputType7129;
		public override int getInputType() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.text.method.DateKeyListener._getInputType7129);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.text.method.DateKeyListener.staticClass, global::android.text.method.DateKeyListener._getInputType7129);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAcceptedChars7130;
		protected override char[] getAcceptedChars() 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.text.method.DateKeyListener._getAcceptedChars7130));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.text.method.DateKeyListener.staticClass, global::android.text.method.DateKeyListener._getAcceptedChars7130));
		}
		internal static global::net.sf.jni4net.jni.MethodId _DateKeyListener7131;
		public DateKeyListener()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.text.method.DateKeyListener.staticClass, global::android.text.method.DateKeyListener._DateKeyListener7131, this);
		}
		internal static global::net.sf.jni4net.jni.FieldId _CHARACTERS7132;
		public static char[] CHARACTERS
		{
			get
			{
				return default(char[]);
			}
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.text.method.DateKeyListener.staticClass = @__class;
			global::android.text.method.DateKeyListener._getInstance7128 = @__env.GetStaticMethodID(global::android.text.method.DateKeyListener.staticClass, "getInstance", "()Landroid/text/method/DateKeyListener;");
			global::android.text.method.DateKeyListener._getInputType7129 = @__env.GetMethodID(global::android.text.method.DateKeyListener.staticClass, "getInputType", "()I");
			global::android.text.method.DateKeyListener._getAcceptedChars7130 = @__env.GetMethodID(global::android.text.method.DateKeyListener.staticClass, "getAcceptedChars", "()[C");
			global::android.text.method.DateKeyListener._DateKeyListener7131 = @__env.GetMethodID(global::android.text.method.DateKeyListener.staticClass, "<init>", "()V");
		}
	}
}
