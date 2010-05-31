namespace android.widget
{
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
	public interface Checkable 
	{
		void toggle();
		bool isChecked();
		void setChecked(bool arg0);
	}

	public partial class Checkable_
	{
		public static global::java.lang.Class _class
		{
			get { return __Checkable.staticClass; }
		}
	}

	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class __Checkable : java.lang.Object, Checkable
	{
		internal static global::java.lang.Class staticClass;
		static __Checkable()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.widget.__Checkable), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.widget.__Checkable(@__env);
			}
		}
		internal __Checkable(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _toggle9986;
		 void android.widget.Checkable.toggle() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.__Checkable._toggle9986);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.__Checkable.staticClass, global::android.widget.__Checkable._toggle9986);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isChecked9987;
		 bool android.widget.Checkable.isChecked() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.__Checkable._isChecked9987);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.__Checkable.staticClass, global::android.widget.__Checkable._isChecked9987);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setChecked9988;
		 void android.widget.Checkable.setChecked(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.__Checkable._setChecked9988, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.__Checkable.staticClass, global::android.widget.__Checkable._setChecked9988, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.widget.__Checkable.staticClass = @__class;
			global::android.widget.__Checkable._toggle9986 = @__env.GetMethodID(global::android.widget.__Checkable.staticClass, "android.widget.Checkable.toggle", "()V");
			global::android.widget.__Checkable._isChecked9987 = @__env.GetMethodID(global::android.widget.__Checkable.staticClass, "android.widget.Checkable.isChecked", "()Z");
			global::android.widget.__Checkable._setChecked9988 = @__env.GetMethodID(global::android.widget.__Checkable.staticClass, "android.widget.Checkable.setChecked", "(Z)V");
		}
	}
}
