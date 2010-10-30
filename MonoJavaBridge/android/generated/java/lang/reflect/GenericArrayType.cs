namespace java.lang.reflect
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.lang.reflect.GenericArrayType_))]
	public partial interface GenericArrayType : Type
	{
		global::java.lang.reflect.Type getGenericComponentType();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.lang.reflect.GenericArrayType))]
	internal sealed partial class GenericArrayType_ : java.lang.Object, GenericArrayType
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal GenericArrayType_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getGenericComponentType21081;
		global::java.lang.reflect.Type java.lang.reflect.GenericArrayType.getGenericComponentType()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.reflect.GenericArrayType_._getGenericComponentType21081.native == global::System.IntPtr.Zero)
				global::java.lang.reflect.GenericArrayType_._getGenericComponentType21081 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.GenericArrayType_.staticClass, "getGenericComponentType", "()Ljava/lang/reflect/Type;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.reflect.Type>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.reflect.GenericArrayType_._getGenericComponentType21081)) as java.lang.reflect.Type;
		}
		static GenericArrayType_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.reflect.GenericArrayType_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/reflect/GenericArrayType"));
		}
		internal static void InitJNI()
		{
		}
	}
}
