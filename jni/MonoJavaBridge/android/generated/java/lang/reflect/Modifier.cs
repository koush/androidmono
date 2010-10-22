namespace java.lang.reflect
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Modifier : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Modifier()
		{
			InitJNI();
		}
		protected Modifier(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString21000;
		public static global::java.lang.String toString(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.lang.reflect.Modifier.staticClass, global::java.lang.reflect.Modifier._toString21000, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isInterface21001;
		public static bool isInterface(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.reflect.Modifier.staticClass, global::java.lang.reflect.Modifier._isInterface21001, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isAbstract21002;
		public static bool isAbstract(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.reflect.Modifier.staticClass, global::java.lang.reflect.Modifier._isAbstract21002, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isProtected21003;
		public static bool isProtected(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.reflect.Modifier.staticClass, global::java.lang.reflect.Modifier._isProtected21003, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isFinal21004;
		public static bool isFinal(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.reflect.Modifier.staticClass, global::java.lang.reflect.Modifier._isFinal21004, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isStatic21005;
		public static bool isStatic(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.reflect.Modifier.staticClass, global::java.lang.reflect.Modifier._isStatic21005, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isPublic21006;
		public static bool isPublic(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.reflect.Modifier.staticClass, global::java.lang.reflect.Modifier._isPublic21006, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isPrivate21007;
		public static bool isPrivate(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.reflect.Modifier.staticClass, global::java.lang.reflect.Modifier._isPrivate21007, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isSynchronized21008;
		public static bool isSynchronized(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.reflect.Modifier.staticClass, global::java.lang.reflect.Modifier._isSynchronized21008, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isVolatile21009;
		public static bool isVolatile(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.reflect.Modifier.staticClass, global::java.lang.reflect.Modifier._isVolatile21009, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isTransient21010;
		public static bool isTransient(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.reflect.Modifier.staticClass, global::java.lang.reflect.Modifier._isTransient21010, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isNative21011;
		public static bool isNative(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.reflect.Modifier.staticClass, global::java.lang.reflect.Modifier._isNative21011, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isStrict21012;
		public static bool isStrict(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.reflect.Modifier.staticClass, global::java.lang.reflect.Modifier._isStrict21012, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _Modifier21013;
		public Modifier()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.reflect.Modifier.staticClass, global::java.lang.reflect.Modifier._Modifier21013);
			Init(@__env, handle);
		}
		public static int PUBLIC
		{
			get
			{
				return 1;
			}
		}
		public static int PRIVATE
		{
			get
			{
				return 2;
			}
		}
		public static int PROTECTED
		{
			get
			{
				return 4;
			}
		}
		public static int STATIC
		{
			get
			{
				return 8;
			}
		}
		public static int FINAL
		{
			get
			{
				return 16;
			}
		}
		public static int SYNCHRONIZED
		{
			get
			{
				return 32;
			}
		}
		public static int VOLATILE
		{
			get
			{
				return 64;
			}
		}
		public static int TRANSIENT
		{
			get
			{
				return 128;
			}
		}
		public static int NATIVE
		{
			get
			{
				return 256;
			}
		}
		public static int INTERFACE
		{
			get
			{
				return 512;
			}
		}
		public static int ABSTRACT
		{
			get
			{
				return 1024;
			}
		}
		public static int STRICT
		{
			get
			{
				return 2048;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.reflect.Modifier.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/reflect/Modifier"));
			global::java.lang.reflect.Modifier._toString21000 = @__env.GetStaticMethodIDNoThrow(global::java.lang.reflect.Modifier.staticClass, "toString", "(I)Ljava/lang/String;");
			global::java.lang.reflect.Modifier._isInterface21001 = @__env.GetStaticMethodIDNoThrow(global::java.lang.reflect.Modifier.staticClass, "isInterface", "(I)Z");
			global::java.lang.reflect.Modifier._isAbstract21002 = @__env.GetStaticMethodIDNoThrow(global::java.lang.reflect.Modifier.staticClass, "isAbstract", "(I)Z");
			global::java.lang.reflect.Modifier._isProtected21003 = @__env.GetStaticMethodIDNoThrow(global::java.lang.reflect.Modifier.staticClass, "isProtected", "(I)Z");
			global::java.lang.reflect.Modifier._isFinal21004 = @__env.GetStaticMethodIDNoThrow(global::java.lang.reflect.Modifier.staticClass, "isFinal", "(I)Z");
			global::java.lang.reflect.Modifier._isStatic21005 = @__env.GetStaticMethodIDNoThrow(global::java.lang.reflect.Modifier.staticClass, "isStatic", "(I)Z");
			global::java.lang.reflect.Modifier._isPublic21006 = @__env.GetStaticMethodIDNoThrow(global::java.lang.reflect.Modifier.staticClass, "isPublic", "(I)Z");
			global::java.lang.reflect.Modifier._isPrivate21007 = @__env.GetStaticMethodIDNoThrow(global::java.lang.reflect.Modifier.staticClass, "isPrivate", "(I)Z");
			global::java.lang.reflect.Modifier._isSynchronized21008 = @__env.GetStaticMethodIDNoThrow(global::java.lang.reflect.Modifier.staticClass, "isSynchronized", "(I)Z");
			global::java.lang.reflect.Modifier._isVolatile21009 = @__env.GetStaticMethodIDNoThrow(global::java.lang.reflect.Modifier.staticClass, "isVolatile", "(I)Z");
			global::java.lang.reflect.Modifier._isTransient21010 = @__env.GetStaticMethodIDNoThrow(global::java.lang.reflect.Modifier.staticClass, "isTransient", "(I)Z");
			global::java.lang.reflect.Modifier._isNative21011 = @__env.GetStaticMethodIDNoThrow(global::java.lang.reflect.Modifier.staticClass, "isNative", "(I)Z");
			global::java.lang.reflect.Modifier._isStrict21012 = @__env.GetStaticMethodIDNoThrow(global::java.lang.reflect.Modifier.staticClass, "isStrict", "(I)Z");
			global::java.lang.reflect.Modifier._Modifier21013 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Modifier.staticClass, "<init>", "()V");
		}
	}
}
