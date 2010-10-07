namespace android.text
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class AutoText : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static AutoText()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.text.AutoText), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.text.AutoText(@__env);
			}
		}
		protected AutoText(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _get7324;
		public static global::java.lang.String get(java.lang.CharSequence arg0, int arg1, int arg2, android.view.View arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.text.AutoText.staticClass, global::android.text.AutoText._get7324, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSize7325;
		public static int getSize(android.view.View arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.text.AutoText.staticClass, global::android.text.AutoText._getSize7325, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.text.AutoText.staticClass = @__class;
			global::android.text.AutoText._get7324 = @__env.GetStaticMethodID(global::android.text.AutoText.staticClass, "get", "(Ljava/lang/CharSequence;IILandroid/view/View;)Ljava/lang/String;");
			global::android.text.AutoText._getSize7325 = @__env.GetStaticMethodID(global::android.text.AutoText.staticClass, "getSize", "(Landroid/view/View;)I");
		}
	}
}
