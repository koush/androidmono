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
		internal static global::MonoJavaBridge.MethodId _toString15476;
		public static global::java.lang.String toString(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.reflect.Modifier.staticClass, global::java.lang.reflect.Modifier._toString15476, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isInterface15477;
		public static bool isInterface(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.reflect.Modifier.staticClass, global::java.lang.reflect.Modifier._isInterface15477, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isAbstract15478;
		public static bool isAbstract(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.reflect.Modifier.staticClass, global::java.lang.reflect.Modifier._isAbstract15478, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isProtected15479;
		public static bool isProtected(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.reflect.Modifier.staticClass, global::java.lang.reflect.Modifier._isProtected15479, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isFinal15480;
		public static bool isFinal(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.reflect.Modifier.staticClass, global::java.lang.reflect.Modifier._isFinal15480, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isStatic15481;
		public static bool isStatic(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.reflect.Modifier.staticClass, global::java.lang.reflect.Modifier._isStatic15481, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isPublic15482;
		public static bool isPublic(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.reflect.Modifier.staticClass, global::java.lang.reflect.Modifier._isPublic15482, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isPrivate15483;
		public static bool isPrivate(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.reflect.Modifier.staticClass, global::java.lang.reflect.Modifier._isPrivate15483, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isSynchronized15484;
		public static bool isSynchronized(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.reflect.Modifier.staticClass, global::java.lang.reflect.Modifier._isSynchronized15484, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isVolatile15485;
		public static bool isVolatile(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.reflect.Modifier.staticClass, global::java.lang.reflect.Modifier._isVolatile15485, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isTransient15486;
		public static bool isTransient(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.reflect.Modifier.staticClass, global::java.lang.reflect.Modifier._isTransient15486, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isNative15487;
		public static bool isNative(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.reflect.Modifier.staticClass, global::java.lang.reflect.Modifier._isNative15487, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isStrict15488;
		public static bool isStrict(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.reflect.Modifier.staticClass, global::java.lang.reflect.Modifier._isStrict15488, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _Modifier15489;
		public Modifier()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.reflect.Modifier.staticClass, global::java.lang.reflect.Modifier._Modifier15489);
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
			global::java.lang.reflect.Modifier._toString15476 = @__env.GetStaticMethodIDNoThrow(global::java.lang.reflect.Modifier.staticClass, "toString", "(I)Ljava/lang/String;");
			global::java.lang.reflect.Modifier._isInterface15477 = @__env.GetStaticMethodIDNoThrow(global::java.lang.reflect.Modifier.staticClass, "isInterface", "(I)Z");
			global::java.lang.reflect.Modifier._isAbstract15478 = @__env.GetStaticMethodIDNoThrow(global::java.lang.reflect.Modifier.staticClass, "isAbstract", "(I)Z");
			global::java.lang.reflect.Modifier._isProtected15479 = @__env.GetStaticMethodIDNoThrow(global::java.lang.reflect.Modifier.staticClass, "isProtected", "(I)Z");
			global::java.lang.reflect.Modifier._isFinal15480 = @__env.GetStaticMethodIDNoThrow(global::java.lang.reflect.Modifier.staticClass, "isFinal", "(I)Z");
			global::java.lang.reflect.Modifier._isStatic15481 = @__env.GetStaticMethodIDNoThrow(global::java.lang.reflect.Modifier.staticClass, "isStatic", "(I)Z");
			global::java.lang.reflect.Modifier._isPublic15482 = @__env.GetStaticMethodIDNoThrow(global::java.lang.reflect.Modifier.staticClass, "isPublic", "(I)Z");
			global::java.lang.reflect.Modifier._isPrivate15483 = @__env.GetStaticMethodIDNoThrow(global::java.lang.reflect.Modifier.staticClass, "isPrivate", "(I)Z");
			global::java.lang.reflect.Modifier._isSynchronized15484 = @__env.GetStaticMethodIDNoThrow(global::java.lang.reflect.Modifier.staticClass, "isSynchronized", "(I)Z");
			global::java.lang.reflect.Modifier._isVolatile15485 = @__env.GetStaticMethodIDNoThrow(global::java.lang.reflect.Modifier.staticClass, "isVolatile", "(I)Z");
			global::java.lang.reflect.Modifier._isTransient15486 = @__env.GetStaticMethodIDNoThrow(global::java.lang.reflect.Modifier.staticClass, "isTransient", "(I)Z");
			global::java.lang.reflect.Modifier._isNative15487 = @__env.GetStaticMethodIDNoThrow(global::java.lang.reflect.Modifier.staticClass, "isNative", "(I)Z");
			global::java.lang.reflect.Modifier._isStrict15488 = @__env.GetStaticMethodIDNoThrow(global::java.lang.reflect.Modifier.staticClass, "isStrict", "(I)Z");
			global::java.lang.reflect.Modifier._Modifier15489 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Modifier.staticClass, "<init>", "()V");
		}
	}
}
