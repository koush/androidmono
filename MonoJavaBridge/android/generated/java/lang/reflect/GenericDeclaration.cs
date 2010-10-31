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
		internal GenericDeclaration_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		global::java.lang.reflect.TypeVariable[] java.lang.reflect.GenericDeclaration.getTypeParameters()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.reflect.TypeVariable>(this, global::java.lang.reflect.GenericDeclaration_.staticClass, "getTypeParameters", "()[Ljava/lang/reflect/TypeVariable;", ref global::java.lang.reflect.GenericDeclaration_._m0) as java.lang.reflect.TypeVariable[];
		}
		static GenericDeclaration_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.reflect.GenericDeclaration_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/reflect/GenericDeclaration"));
		}
	}
}
