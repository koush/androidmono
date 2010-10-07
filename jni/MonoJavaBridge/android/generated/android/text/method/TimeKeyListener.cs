namespace android.text.method
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class TimeKeyListener : android.text.method.NumberKeyListener
	{
		internal new static global::java.lang.Class staticClass;
		static TimeKeyListener()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.text.method.TimeKeyListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.text.method.TimeKeyListener(@__env);
			}
		}
		protected TimeKeyListener(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _getInstance7892;
		public static global::android.text.method.TimeKeyListener getInstance() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.text.method.TimeKeyListener>(@__env, @__env.CallStaticObjectMethodPtr(android.text.method.TimeKeyListener.staticClass, global::android.text.method.TimeKeyListener._getInstance7892));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getInputType7893;
		public override int getInputType() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.text.method.TimeKeyListener._getInputType7893);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.text.method.TimeKeyListener.staticClass, global::android.text.method.TimeKeyListener._getInputType7893);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAcceptedChars7894;
		protected override char[] getAcceptedChars() 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.text.method.TimeKeyListener._getAcceptedChars7894));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.text.method.TimeKeyListener.staticClass, global::android.text.method.TimeKeyListener._getAcceptedChars7894));
		}
		internal static global::net.sf.jni4net.jni.MethodId _TimeKeyListener7895;
		public TimeKeyListener()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.text.method.TimeKeyListener.staticClass, global::android.text.method.TimeKeyListener._TimeKeyListener7895, this);
		}
		internal static global::net.sf.jni4net.jni.FieldId _CHARACTERS7896;
		public static char[] CHARACTERS
		{
			get
			{
				return default(char[]);
			}
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.text.method.TimeKeyListener.staticClass = @__class;
			global::android.text.method.TimeKeyListener._getInstance7892 = @__env.GetStaticMethodID(global::android.text.method.TimeKeyListener.staticClass, "getInstance", "()Landroid/text/method/TimeKeyListener;");
			global::android.text.method.TimeKeyListener._getInputType7893 = @__env.GetMethodID(global::android.text.method.TimeKeyListener.staticClass, "getInputType", "()I");
			global::android.text.method.TimeKeyListener._getAcceptedChars7894 = @__env.GetMethodID(global::android.text.method.TimeKeyListener.staticClass, "getAcceptedChars", "()[C");
			global::android.text.method.TimeKeyListener._TimeKeyListener7895 = @__env.GetMethodID(global::android.text.method.TimeKeyListener.staticClass, "<init>", "()V");
		}
	}
}
