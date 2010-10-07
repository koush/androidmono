namespace android.text.method
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class DateTimeKeyListener : android.text.method.NumberKeyListener
	{
		internal new static global::java.lang.Class staticClass;
		static DateTimeKeyListener()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.text.method.DateTimeKeyListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.text.method.DateTimeKeyListener(@__env);
			}
		}
		protected DateTimeKeyListener(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _getInstance7759;
		public static global::android.text.method.DateTimeKeyListener getInstance() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.text.method.DateTimeKeyListener>(@__env, @__env.CallStaticObjectMethodPtr(android.text.method.DateTimeKeyListener.staticClass, global::android.text.method.DateTimeKeyListener._getInstance7759));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getInputType7760;
		public override int getInputType() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.text.method.DateTimeKeyListener._getInputType7760);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.text.method.DateTimeKeyListener.staticClass, global::android.text.method.DateTimeKeyListener._getInputType7760);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAcceptedChars7761;
		protected override char[] getAcceptedChars() 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.text.method.DateTimeKeyListener._getAcceptedChars7761));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.text.method.DateTimeKeyListener.staticClass, global::android.text.method.DateTimeKeyListener._getAcceptedChars7761));
		}
		internal static global::net.sf.jni4net.jni.MethodId _DateTimeKeyListener7762;
		public DateTimeKeyListener()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.text.method.DateTimeKeyListener.staticClass, global::android.text.method.DateTimeKeyListener._DateTimeKeyListener7762, this);
		}
		internal static global::net.sf.jni4net.jni.FieldId _CHARACTERS7763;
		public static char[] CHARACTERS
		{
			get
			{
				return default(char[]);
			}
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.text.method.DateTimeKeyListener.staticClass = @__class;
			global::android.text.method.DateTimeKeyListener._getInstance7759 = @__env.GetStaticMethodID(global::android.text.method.DateTimeKeyListener.staticClass, "getInstance", "()Landroid/text/method/DateTimeKeyListener;");
			global::android.text.method.DateTimeKeyListener._getInputType7760 = @__env.GetMethodID(global::android.text.method.DateTimeKeyListener.staticClass, "getInputType", "()I");
			global::android.text.method.DateTimeKeyListener._getAcceptedChars7761 = @__env.GetMethodID(global::android.text.method.DateTimeKeyListener.staticClass, "getAcceptedChars", "()[C");
			global::android.text.method.DateTimeKeyListener._DateTimeKeyListener7762 = @__env.GetMethodID(global::android.text.method.DateTimeKeyListener.staticClass, "<init>", "()V");
		}
	}
}
