namespace java.util
{
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
	public interface Observer 
	{
		void update(java.util.Observable arg0, java.lang.Object arg1);
	}

	public partial class Observer_
	{
		public static global::java.lang.Class _class
		{
			get { return __Observer.staticClass; }
		}
	}

	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class __Observer : java.lang.Object, Observer
	{
		internal static global::java.lang.Class staticClass;
		static __Observer()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::java.util.__Observer), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::java.util.__Observer(@__env);
			}
		}
		internal __Observer(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _update12960;
		 void java.util.Observer.update(java.util.Observable arg0, java.lang.Object arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.util.__Observer._update12960, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.util.__Observer.staticClass, global::java.util.__Observer._update12960, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::java.util.__Observer.staticClass = @__class;
			global::java.util.__Observer._update12960 = @__env.GetMethodID(global::java.util.__Observer.staticClass, "java.util.Observer.update", "(Ljava/util/Observable;Ljava/lang/Object;)V");
		}
	}
}
