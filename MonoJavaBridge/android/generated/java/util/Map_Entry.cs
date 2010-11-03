namespace java.util
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.util.Map_Entry_))]
	public partial interface Map_Entry  : global::MonoJavaBridge.IJavaObject 
	{
		bool equals(java.lang.Object arg0);
		int hashCode();
		global::java.lang.Object getValue();
		global::java.lang.Object getKey();
		global::java.lang.Object setValue(java.lang.Object arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.Map_Entry))]
	internal sealed partial class Map_Entry_ : java.lang.Object, Map_Entry
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Map_Entry_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		bool java.util.Map_Entry.equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Map_Entry_.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.util.Map_Entry_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		int java.util.Map_Entry.hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.Map_Entry_.staticClass, "hashCode", "()I", ref global::java.util.Map_Entry_._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		global::java.lang.Object java.util.Map_Entry.getValue()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.Map_Entry_.staticClass, "getValue", "()Ljava/lang/Object;", ref global::java.util.Map_Entry_._m2) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		global::java.lang.Object java.util.Map_Entry.getKey()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.Map_Entry_.staticClass, "getKey", "()Ljava/lang/Object;", ref global::java.util.Map_Entry_._m3) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		global::java.lang.Object java.util.Map_Entry.setValue(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.Map_Entry_.staticClass, "setValue", "(Ljava/lang/Object;)Ljava/lang/Object;", ref global::java.util.Map_Entry_._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		static Map_Entry_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.Map_Entry_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/Map$Entry"));
		}
	}
}
