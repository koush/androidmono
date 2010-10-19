namespace java.util
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.util.Comparator_))]
	public interface Comparator  : global::MonoJavaBridge.IJavaObject 
	{
		bool equals(java.lang.Object arg0);
		int compare(java.lang.Object arg0, java.lang.Object arg1);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.Comparator))]
	public sealed partial class Comparator_ : java.lang.Object, Comparator
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Comparator_()
		{
			InitJNI();
		}
		internal Comparator_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals20137;
		 bool java.util.Comparator.equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Comparator_._equals20137, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Comparator_.staticClass, global::java.util.Comparator_._equals20137, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compare20138;
		 int java.util.Comparator.compare(java.lang.Object arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Comparator_._compare20138, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Comparator_.staticClass, global::java.util.Comparator_._compare20138, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.Comparator_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/Comparator"));
			global::java.util.Comparator_._equals20137 = @__env.GetMethodIDNoThrow(global::java.util.Comparator_.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.util.Comparator_._compare20138 = @__env.GetMethodIDNoThrow(global::java.util.Comparator_.staticClass, "compare", "(Ljava/lang/Object;Ljava/lang/Object;)I");
		}
	}
}
