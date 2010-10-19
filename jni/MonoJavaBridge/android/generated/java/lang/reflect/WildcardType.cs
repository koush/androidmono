namespace java.lang.reflect
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.lang.reflect.WildcardType_))]
	public interface WildcardType : Type
	{
		global::java.lang.reflect.Type[] getUpperBounds();
		global::java.lang.reflect.Type[] getLowerBounds();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.lang.reflect.WildcardType))]
	public sealed partial class WildcardType_ : java.lang.Object, WildcardType
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static WildcardType_()
		{
			InitJNI();
		}
		internal WildcardType_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getUpperBounds15507;
		 global::java.lang.reflect.Type[] java.lang.reflect.WildcardType.getUpperBounds() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.reflect.Type>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.reflect.WildcardType_._getUpperBounds15507)) as java.lang.reflect.Type[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.reflect.Type>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.reflect.WildcardType_.staticClass, global::java.lang.reflect.WildcardType_._getUpperBounds15507)) as java.lang.reflect.Type[];
		}
		internal static global::MonoJavaBridge.MethodId _getLowerBounds15508;
		 global::java.lang.reflect.Type[] java.lang.reflect.WildcardType.getLowerBounds() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.reflect.Type>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.reflect.WildcardType_._getLowerBounds15508)) as java.lang.reflect.Type[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.reflect.Type>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.reflect.WildcardType_.staticClass, global::java.lang.reflect.WildcardType_._getLowerBounds15508)) as java.lang.reflect.Type[];
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.reflect.WildcardType_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/reflect/WildcardType"));
			global::java.lang.reflect.WildcardType_._getUpperBounds15507 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.WildcardType_.staticClass, "getUpperBounds", "()[Ljava/lang/reflect/Type;");
			global::java.lang.reflect.WildcardType_._getLowerBounds15508 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.WildcardType_.staticClass, "getLowerBounds", "()[Ljava/lang/reflect/Type;");
		}
	}
}
