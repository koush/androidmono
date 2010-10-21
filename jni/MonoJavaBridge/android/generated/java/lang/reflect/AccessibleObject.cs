namespace java.lang.reflect
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AccessibleObject : java.lang.Object, AnnotatedElement
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AccessibleObject()
		{
			InitJNI();
		}
		protected AccessibleObject(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getAnnotation20880;
		public virtual global::java.lang.annotation.Annotation getAnnotation(java.lang.Class arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.annotation.Annotation>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.reflect.AccessibleObject._getAnnotation20880, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.annotation.Annotation;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.annotation.Annotation>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.reflect.AccessibleObject.staticClass, global::java.lang.reflect.AccessibleObject._getAnnotation20880, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.annotation.Annotation;
		}
		internal static global::MonoJavaBridge.MethodId _isAnnotationPresent20881;
		public virtual bool isAnnotationPresent(java.lang.Class arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.reflect.AccessibleObject._isAnnotationPresent20881, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.reflect.AccessibleObject.staticClass, global::java.lang.reflect.AccessibleObject._isAnnotationPresent20881, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.annotation.Annotation[] Annotations
		{
			get
			{
				return getAnnotations();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAnnotations20882;
		public virtual global::java.lang.annotation.Annotation[] getAnnotations() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.annotation.Annotation>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.reflect.AccessibleObject._getAnnotations20882)) as java.lang.annotation.Annotation[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.annotation.Annotation>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.reflect.AccessibleObject.staticClass, global::java.lang.reflect.AccessibleObject._getAnnotations20882)) as java.lang.annotation.Annotation[];
		}
		public new global::java.lang.annotation.Annotation[] DeclaredAnnotations
		{
			get
			{
				return getDeclaredAnnotations();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDeclaredAnnotations20883;
		public virtual global::java.lang.annotation.Annotation[] getDeclaredAnnotations() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.annotation.Annotation>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.reflect.AccessibleObject._getDeclaredAnnotations20883)) as java.lang.annotation.Annotation[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.annotation.Annotation>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.reflect.AccessibleObject.staticClass, global::java.lang.reflect.AccessibleObject._getDeclaredAnnotations20883)) as java.lang.annotation.Annotation[];
		}
		internal static global::MonoJavaBridge.MethodId _setAccessible20884;
		public static void setAccessible(java.lang.reflect.AccessibleObject[] arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.lang.reflect.AccessibleObject.staticClass, global::java.lang.reflect.AccessibleObject._setAccessible20884, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setAccessible20885;
		public virtual void setAccessible(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.reflect.AccessibleObject._setAccessible20885, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.reflect.AccessibleObject.staticClass, global::java.lang.reflect.AccessibleObject._setAccessible20885, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isAccessible20886;
		public virtual bool isAccessible() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.reflect.AccessibleObject._isAccessible20886);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.reflect.AccessibleObject.staticClass, global::java.lang.reflect.AccessibleObject._isAccessible20886);
		}
		internal static global::MonoJavaBridge.MethodId _AccessibleObject20887;
		protected AccessibleObject()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.reflect.AccessibleObject.staticClass, global::java.lang.reflect.AccessibleObject._AccessibleObject20887);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.reflect.AccessibleObject.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/reflect/AccessibleObject"));
			global::java.lang.reflect.AccessibleObject._getAnnotation20880 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.AccessibleObject.staticClass, "getAnnotation", "(Ljava/lang/Class;)Ljava/lang/annotation/Annotation;");
			global::java.lang.reflect.AccessibleObject._isAnnotationPresent20881 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.AccessibleObject.staticClass, "isAnnotationPresent", "(Ljava/lang/Class;)Z");
			global::java.lang.reflect.AccessibleObject._getAnnotations20882 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.AccessibleObject.staticClass, "getAnnotations", "()[Ljava/lang/annotation/Annotation;");
			global::java.lang.reflect.AccessibleObject._getDeclaredAnnotations20883 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.AccessibleObject.staticClass, "getDeclaredAnnotations", "()[Ljava/lang/annotation/Annotation;");
			global::java.lang.reflect.AccessibleObject._setAccessible20884 = @__env.GetStaticMethodIDNoThrow(global::java.lang.reflect.AccessibleObject.staticClass, "setAccessible", "([Ljava/lang/reflect/AccessibleObject;Z)V");
			global::java.lang.reflect.AccessibleObject._setAccessible20885 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.AccessibleObject.staticClass, "setAccessible", "(Z)V");
			global::java.lang.reflect.AccessibleObject._isAccessible20886 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.AccessibleObject.staticClass, "isAccessible", "()Z");
			global::java.lang.reflect.AccessibleObject._AccessibleObject20887 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.AccessibleObject.staticClass, "<init>", "()V");
		}
	}
}
