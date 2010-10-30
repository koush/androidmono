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
		internal static global::MonoJavaBridge.MethodId _equals26497;
		bool java.util.Map_Entry.equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Map_Entry_.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.util.Map_Entry_._equals26497, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode26498;
		int java.util.Map_Entry.hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.Map_Entry_.staticClass, "hashCode", "()I", ref global::java.util.Map_Entry_._hashCode26498);
		}
		internal static global::MonoJavaBridge.MethodId _getValue26499;
		global::java.lang.Object java.util.Map_Entry.getValue()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.Map_Entry_.staticClass, "getValue", "()Ljava/lang/Object;", ref global::java.util.Map_Entry_._getValue26499) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getKey26500;
		global::java.lang.Object java.util.Map_Entry.getKey()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.Map_Entry_.staticClass, "getKey", "()Ljava/lang/Object;", ref global::java.util.Map_Entry_._getKey26500) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _setValue26501;
		global::java.lang.Object java.util.Map_Entry.setValue(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.Map_Entry_.staticClass, "setValue", "(Ljava/lang/Object;)Ljava/lang/Object;", ref global::java.util.Map_Entry_._setValue26501, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		static Map_Entry_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.Map_Entry_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/Map$Entry"));
		}
		internal static void InitJNI()
		{
		}
	}
}
