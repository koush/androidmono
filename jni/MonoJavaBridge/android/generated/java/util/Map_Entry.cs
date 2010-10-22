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
	public sealed partial class Map_Entry_ : java.lang.Object, Map_Entry
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Map_Entry_()
		{
			InitJNI();
		}
		internal Map_Entry_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals26378;
		 bool java.util.Map_Entry.equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Map_Entry_._equals26378, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Map_Entry_.staticClass, global::java.util.Map_Entry_._equals26378, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode26379;
		 int java.util.Map_Entry.hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Map_Entry_._hashCode26379);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Map_Entry_.staticClass, global::java.util.Map_Entry_._hashCode26379);
		}
		internal static global::MonoJavaBridge.MethodId _getValue26380;
		 global::java.lang.Object java.util.Map_Entry.getValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Map_Entry_._getValue26380)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Map_Entry_.staticClass, global::java.util.Map_Entry_._getValue26380)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getKey26381;
		 global::java.lang.Object java.util.Map_Entry.getKey() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Map_Entry_._getKey26381)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Map_Entry_.staticClass, global::java.util.Map_Entry_._getKey26381)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _setValue26382;
		 global::java.lang.Object java.util.Map_Entry.setValue(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Map_Entry_._setValue26382, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Map_Entry_.staticClass, global::java.util.Map_Entry_._setValue26382, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.Map_Entry_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/Map_Entry"));
			global::java.util.Map_Entry_._equals26378 = @__env.GetMethodIDNoThrow(global::java.util.Map_Entry_.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.util.Map_Entry_._hashCode26379 = @__env.GetMethodIDNoThrow(global::java.util.Map_Entry_.staticClass, "hashCode", "()I");
			global::java.util.Map_Entry_._getValue26380 = @__env.GetMethodIDNoThrow(global::java.util.Map_Entry_.staticClass, "getValue", "()Ljava/lang/Object;");
			global::java.util.Map_Entry_._getKey26381 = @__env.GetMethodIDNoThrow(global::java.util.Map_Entry_.staticClass, "getKey", "()Ljava/lang/Object;");
			global::java.util.Map_Entry_._setValue26382 = @__env.GetMethodIDNoThrow(global::java.util.Map_Entry_.staticClass, "setValue", "(Ljava/lang/Object;)Ljava/lang/Object;");
		}
	}
}
