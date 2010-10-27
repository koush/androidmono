namespace java.lang.reflect
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.lang.reflect.GenericDeclaration_))]
	public partial interface GenericDeclaration  : global::MonoJavaBridge.IJavaObject 
	{
		global::java.lang.reflect.TypeVariable[] getTypeParameters();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.lang.reflect.GenericDeclaration))]
	internal sealed partial class GenericDeclaration_ : java.lang.Object, GenericDeclaration
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static GenericDeclaration_()
		{
			InitJNI();
		}
		internal GenericDeclaration_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getTypeParameters21081;
		global::java.lang.reflect.TypeVariable[] java.lang.reflect.GenericDeclaration.getTypeParameters()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.reflect.TypeVariable>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.reflect.GenericDeclaration_._getTypeParameters21081)) as java.lang.reflect.TypeVariable[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.reflect.TypeVariable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.reflect.GenericDeclaration_.staticClass, global::java.lang.reflect.GenericDeclaration_._getTypeParameters21081)) as java.lang.reflect.TypeVariable[];
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.reflect.GenericDeclaration_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/reflect/GenericDeclaration"));
			global::java.lang.reflect.GenericDeclaration_._getTypeParameters21081 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.GenericDeclaration_.staticClass, "getTypeParameters", "()[Ljava/lang/reflect/TypeVariable;");
		}
	}
}
