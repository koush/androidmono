namespace android.widget
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class CheckBox : android.widget.CompoundButton
	{
		internal new static global::java.lang.Class staticClass;
		static CheckBox()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.widget.CheckBox), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.widget.CheckBox(@__env);
			}
		}
		protected CheckBox(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _CheckBox10685;
		public CheckBox(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.CheckBox.staticClass, global::android.widget.CheckBox._CheckBox10685, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _CheckBox10686;
		public CheckBox(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.CheckBox.staticClass, global::android.widget.CheckBox._CheckBox10686, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _CheckBox10687;
		public CheckBox(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.CheckBox.staticClass, global::android.widget.CheckBox._CheckBox10687, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.widget.CheckBox.staticClass = @__class;
			global::android.widget.CheckBox._CheckBox10685 = @__env.GetMethodID(global::android.widget.CheckBox.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.widget.CheckBox._CheckBox10686 = @__env.GetMethodID(global::android.widget.CheckBox.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.widget.CheckBox._CheckBox10687 = @__env.GetMethodID(global::android.widget.CheckBox.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
		}
	}
}
