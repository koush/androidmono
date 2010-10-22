namespace java.lang.reflect
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.lang.reflect.TypeVariable_))]
	public partial interface TypeVariable : Type
	{
		global::java.lang.String getName();
		global::java.lang.reflect.Type[] getBounds();
		global::java.lang.reflect.GenericDeclaration getGenericDeclaration();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.lang.reflect.TypeVariable))]
	public sealed partial class TypeVariable_ : java.lang.Object, TypeVariable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static TypeVariable_()
		{
			InitJNI();
		}
		internal TypeVariable_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getName21036;
		 global::java.lang.String java.lang.reflect.TypeVariable.getName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.reflect.TypeVariable_._getName21036)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.reflect.TypeVariable_.staticClass, global::java.lang.reflect.TypeVariable_._getName21036)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getBounds21037;
		 global::java.lang.reflect.Type[] java.lang.reflect.TypeVariable.getBounds() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.reflect.Type>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.reflect.TypeVariable_._getBounds21037)) as java.lang.reflect.Type[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.reflect.Type>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.reflect.TypeVariable_.staticClass, global::java.lang.reflect.TypeVariable_._getBounds21037)) as java.lang.reflect.Type[];
		}
		internal static global::MonoJavaBridge.MethodId _getGenericDeclaration21038;
		 global::java.lang.reflect.GenericDeclaration java.lang.reflect.TypeVariable.getGenericDeclaration() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.reflect.GenericDeclaration>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.reflect.TypeVariable_._getGenericDeclaration21038)) as java.lang.reflect.GenericDeclaration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.reflect.GenericDeclaration>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.reflect.TypeVariable_.staticClass, global::java.lang.reflect.TypeVariable_._getGenericDeclaration21038)) as java.lang.reflect.GenericDeclaration;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.reflect.TypeVariable_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/reflect/TypeVariable"));
			global::java.lang.reflect.TypeVariable_._getName21036 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.TypeVariable_.staticClass, "getName", "()Ljava/lang/String;");
			global::java.lang.reflect.TypeVariable_._getBounds21037 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.TypeVariable_.staticClass, "getBounds", "()[Ljava/lang/reflect/Type;");
			global::java.lang.reflect.TypeVariable_._getGenericDeclaration21038 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.TypeVariable_.staticClass, "getGenericDeclaration", "()Ljava/lang/reflect/GenericDeclaration;");
		}
	}
}
