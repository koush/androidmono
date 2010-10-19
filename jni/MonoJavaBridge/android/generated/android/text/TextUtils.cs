namespace android.text
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class TextUtils : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static TextUtils()
		{
			InitJNI();
		}
		protected TextUtils(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.text.TextUtils.EllipsizeCallback_))]
		public interface EllipsizeCallback  : global::MonoJavaBridge.IJavaObject 
		{
			void ellipsized(int arg0, int arg1);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.text.TextUtils.EllipsizeCallback))]
		public sealed partial class EllipsizeCallback_ : java.lang.Object, EllipsizeCallback
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static EllipsizeCallback_()
			{
				InitJNI();
			}
			internal EllipsizeCallback_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _ellipsized8445;
			 void android.text.TextUtils.EllipsizeCallback.ellipsized(int arg0, int arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.text.TextUtils.EllipsizeCallback_._ellipsized8445, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.TextUtils.EllipsizeCallback_.staticClass, global::android.text.TextUtils.EllipsizeCallback_._ellipsized8445, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.text.TextUtils.EllipsizeCallback_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/TextUtils$EllipsizeCallback"));
				global::android.text.TextUtils.EllipsizeCallback_._ellipsized8445 = @__env.GetMethodIDNoThrow(global::android.text.TextUtils.EllipsizeCallback_.staticClass, "ellipsized", "(II)V");
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class SimpleStringSplitter : java.lang.Object, StringSplitter, java.util.Iterator
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static SimpleStringSplitter()
			{
				InitJNI();
			}
			protected SimpleStringSplitter(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _iterator8446;
			public virtual global::java.util.Iterator iterator() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.TextUtils.SimpleStringSplitter._iterator8446)) as java.util.Iterator;
				else
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.TextUtils.SimpleStringSplitter.staticClass, global::android.text.TextUtils.SimpleStringSplitter._iterator8446)) as java.util.Iterator;
			}
			internal static global::MonoJavaBridge.MethodId _hasNext8447;
			public virtual bool hasNext() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.text.TextUtils.SimpleStringSplitter._hasNext8447);
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.text.TextUtils.SimpleStringSplitter.staticClass, global::android.text.TextUtils.SimpleStringSplitter._hasNext8447);
			}
			internal static global::MonoJavaBridge.MethodId _next8448;
			public virtual global::java.lang.Object next() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.text.TextUtils.SimpleStringSplitter._next8448)) as java.lang.Object;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.TextUtils.SimpleStringSplitter.staticClass, global::android.text.TextUtils.SimpleStringSplitter._next8448)) as java.lang.Object;
			}
			internal static global::MonoJavaBridge.MethodId _remove8449;
			public virtual void remove() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.text.TextUtils.SimpleStringSplitter._remove8449);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.TextUtils.SimpleStringSplitter.staticClass, global::android.text.TextUtils.SimpleStringSplitter._remove8449);
			}
			internal static global::MonoJavaBridge.MethodId _setString8450;
			public virtual void setString(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.text.TextUtils.SimpleStringSplitter._setString8450, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.TextUtils.SimpleStringSplitter.staticClass, global::android.text.TextUtils.SimpleStringSplitter._setString8450, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _SimpleStringSplitter8451;
			public SimpleStringSplitter(char arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.TextUtils.SimpleStringSplitter.staticClass, global::android.text.TextUtils.SimpleStringSplitter._SimpleStringSplitter8451, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.text.TextUtils.SimpleStringSplitter.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/TextUtils$SimpleStringSplitter"));
				global::android.text.TextUtils.SimpleStringSplitter._iterator8446 = @__env.GetMethodIDNoThrow(global::android.text.TextUtils.SimpleStringSplitter.staticClass, "iterator", "()Ljava/util/Iterator;");
				global::android.text.TextUtils.SimpleStringSplitter._hasNext8447 = @__env.GetMethodIDNoThrow(global::android.text.TextUtils.SimpleStringSplitter.staticClass, "hasNext", "()Z");
				global::android.text.TextUtils.SimpleStringSplitter._next8448 = @__env.GetMethodIDNoThrow(global::android.text.TextUtils.SimpleStringSplitter.staticClass, "next", "()Ljava/lang/Object;");
				global::android.text.TextUtils.SimpleStringSplitter._remove8449 = @__env.GetMethodIDNoThrow(global::android.text.TextUtils.SimpleStringSplitter.staticClass, "remove", "()V");
				global::android.text.TextUtils.SimpleStringSplitter._setString8450 = @__env.GetMethodIDNoThrow(global::android.text.TextUtils.SimpleStringSplitter.staticClass, "setString", "(Ljava/lang/String;)V");
				global::android.text.TextUtils.SimpleStringSplitter._SimpleStringSplitter8451 = @__env.GetMethodIDNoThrow(global::android.text.TextUtils.SimpleStringSplitter.staticClass, "<init>", "(C)V");
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.text.TextUtils.StringSplitter_))]
		public interface StringSplitter : java.lang.Iterable
		{
			void setString(java.lang.String arg0);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.text.TextUtils.StringSplitter))]
		public sealed partial class StringSplitter_ : java.lang.Object, StringSplitter
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static StringSplitter_()
			{
				InitJNI();
			}
			internal StringSplitter_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _setString8452;
			 void android.text.TextUtils.StringSplitter.setString(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.text.TextUtils.StringSplitter_._setString8452, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.TextUtils.StringSplitter_.staticClass, global::android.text.TextUtils.StringSplitter_._setString8452, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _iterator8453;
			 global::java.util.Iterator java.lang.Iterable.iterator() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.TextUtils.StringSplitter_._iterator8453)) as java.util.Iterator;
				else
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.TextUtils.StringSplitter_.staticClass, global::android.text.TextUtils.StringSplitter_._iterator8453)) as java.util.Iterator;
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.text.TextUtils.StringSplitter_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/TextUtils$StringSplitter"));
				global::android.text.TextUtils.StringSplitter_._setString8452 = @__env.GetMethodIDNoThrow(global::android.text.TextUtils.StringSplitter_.staticClass, "setString", "(Ljava/lang/String;)V");
				global::android.text.TextUtils.StringSplitter_._iterator8453 = @__env.GetMethodIDNoThrow(global::android.text.TextUtils.StringSplitter_.staticClass, "iterator", "()Ljava/util/Iterator;");
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class TruncateAt : java.lang.Enum
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static TruncateAt()
			{
				InitJNI();
			}
			internal TruncateAt(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _values8454;
			public static global::android.text.TextUtils.TruncateAt[] values() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.text.TextUtils.TruncateAt>(@__env.CallStaticObjectMethod(android.text.TextUtils.TruncateAt.staticClass, global::android.text.TextUtils.TruncateAt._values8454)) as android.text.TextUtils.TruncateAt[];
			}
			internal static global::MonoJavaBridge.MethodId _valueOf8455;
			public static global::android.text.TextUtils.TruncateAt valueOf(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.text.TextUtils.TruncateAt.staticClass, global::android.text.TextUtils.TruncateAt._valueOf8455, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.text.TextUtils.TruncateAt;
			}
			internal static global::MonoJavaBridge.FieldId _END8456;
			public static global::android.text.TextUtils.TruncateAt END
			{
				get
				{
					return default(global::android.text.TextUtils.TruncateAt);
				}
			}
			internal static global::MonoJavaBridge.FieldId _MARQUEE8457;
			public static global::android.text.TextUtils.TruncateAt MARQUEE
			{
				get
				{
					return default(global::android.text.TextUtils.TruncateAt);
				}
			}
			internal static global::MonoJavaBridge.FieldId _MIDDLE8458;
			public static global::android.text.TextUtils.TruncateAt MIDDLE
			{
				get
				{
					return default(global::android.text.TextUtils.TruncateAt);
				}
			}
			internal static global::MonoJavaBridge.FieldId _START8459;
			public static global::android.text.TextUtils.TruncateAt START
			{
				get
				{
					return default(global::android.text.TextUtils.TruncateAt);
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.text.TextUtils.TruncateAt.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/TextUtils$TruncateAt"));
				global::android.text.TextUtils.TruncateAt._values8454 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.TruncateAt.staticClass, "values", "()[Landroid/text/TextUtils/TruncateAt;");
				global::android.text.TextUtils.TruncateAt._valueOf8455 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.TruncateAt.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/text/TextUtils$TruncateAt;");
			}
		}
		internal static global::MonoJavaBridge.MethodId _equals8460;
		public static bool equals(java.lang.CharSequence arg0, java.lang.CharSequence arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._equals8460, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _indexOf8461;
		public static int indexOf(java.lang.CharSequence arg0, char arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._indexOf8461, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _indexOf8462;
		public static int indexOf(java.lang.CharSequence arg0, char arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._indexOf8462, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _indexOf8463;
		public static int indexOf(java.lang.CharSequence arg0, char arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._indexOf8463, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _indexOf8464;
		public static int indexOf(java.lang.CharSequence arg0, java.lang.CharSequence arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._indexOf8464, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _indexOf8465;
		public static int indexOf(java.lang.CharSequence arg0, java.lang.CharSequence arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._indexOf8465, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _indexOf8466;
		public static int indexOf(java.lang.CharSequence arg0, java.lang.CharSequence arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._indexOf8466, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty8467;
		public static bool isEmpty(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._isEmpty8467, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getChars8468;
		public static void getChars(java.lang.CharSequence arg0, int arg1, int arg2, char[] arg3, int arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._getChars8468, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _regionMatches8469;
		public static bool regionMatches(java.lang.CharSequence arg0, int arg1, java.lang.CharSequence arg2, int arg3, int arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._regionMatches8469, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _lastIndexOf8470;
		public static int lastIndexOf(java.lang.CharSequence arg0, char arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._lastIndexOf8470, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _lastIndexOf8471;
		public static int lastIndexOf(java.lang.CharSequence arg0, char arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._lastIndexOf8471, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _lastIndexOf8472;
		public static int lastIndexOf(java.lang.CharSequence arg0, char arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._lastIndexOf8472, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _substring8473;
		public static global::java.lang.String substring(java.lang.CharSequence arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._substring8473, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _concat8474;
		public static global::java.lang.CharSequence concat(java.lang.CharSequence[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallStaticObjectMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._concat8474, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _replace8475;
		public static global::java.lang.CharSequence replace(java.lang.CharSequence arg0, java.lang.String[] arg1, java.lang.CharSequence[] arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallStaticObjectMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._replace8475, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _split8476;
		public static global::java.lang.String[] split(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallStaticObjectMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._split8476, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _split8477;
		public static global::java.lang.String[] split(java.lang.String arg0, java.util.regex.Pattern arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallStaticObjectMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._split8477, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _join8478;
		public static global::java.lang.String join(java.lang.CharSequence arg0, java.lang.Object[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._join8478, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _join8479;
		public static global::java.lang.String join(java.lang.CharSequence arg0, java.lang.Iterable arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._join8479, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _ellipsize8480;
		public static global::java.lang.CharSequence ellipsize(java.lang.CharSequence arg0, android.text.TextPaint arg1, float arg2, android.text.TextUtils.TruncateAt arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallStaticObjectMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._ellipsize8480, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _ellipsize8481;
		public static global::java.lang.CharSequence ellipsize(java.lang.CharSequence arg0, android.text.TextPaint arg1, float arg2, android.text.TextUtils.TruncateAt arg3, bool arg4, android.text.TextUtils.EllipsizeCallback arg5) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallStaticObjectMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._ellipsize8481, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5))) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel8482;
		public static void writeToParcel(java.lang.CharSequence arg0, android.os.Parcel arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._writeToParcel8482, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _stringOrSpannedString8483;
		public static global::java.lang.CharSequence stringOrSpannedString(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallStaticObjectMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._stringOrSpannedString8483, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _getTrimmedLength8484;
		public static int getTrimmedLength(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._getTrimmedLength8484, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getReverse8485;
		public static global::java.lang.CharSequence getReverse(java.lang.CharSequence arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallStaticObjectMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._getReverse8485, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _dumpSpans8486;
		public static void dumpSpans(java.lang.CharSequence arg0, android.util.Printer arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._dumpSpans8486, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _expandTemplate8487;
		public static global::java.lang.CharSequence expandTemplate(java.lang.CharSequence arg0, java.lang.CharSequence[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallStaticObjectMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._expandTemplate8487, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _getOffsetBefore8488;
		public static int getOffsetBefore(java.lang.CharSequence arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._getOffsetBefore8488, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getOffsetAfter8489;
		public static int getOffsetAfter(java.lang.CharSequence arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._getOffsetAfter8489, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _copySpansFrom8490;
		public static void copySpansFrom(android.text.Spanned arg0, int arg1, int arg2, java.lang.Class arg3, android.text.Spannable arg4, int arg5) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._copySpansFrom8490, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _commaEllipsize8491;
		public static global::java.lang.CharSequence commaEllipsize(java.lang.CharSequence arg0, android.text.TextPaint arg1, float arg2, java.lang.String arg3, java.lang.String arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallStaticObjectMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._commaEllipsize8491, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _htmlEncode8492;
		public static global::java.lang.String htmlEncode(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._htmlEncode8492, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isGraphic8493;
		public static bool isGraphic(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._isGraphic8493, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isGraphic8494;
		public static bool isGraphic(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._isGraphic8494, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isDigitsOnly8495;
		public static bool isDigitsOnly(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._isDigitsOnly8495, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getCapsMode8496;
		public static int getCapsMode(java.lang.CharSequence arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._getCapsMode8496, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.FieldId _CHAR_SEQUENCE_CREATOR8497;
		public static global::android.os.Parcelable_Creator CHAR_SEQUENCE_CREATOR
		{
			get
			{
				return default(global::android.os.Parcelable_Creator);
			}
		}
		public static int CAP_MODE_CHARACTERS
		{
			get
			{
				return 4096;
			}
		}
		public static int CAP_MODE_WORDS
		{
			get
			{
				return 8192;
			}
		}
		public static int CAP_MODE_SENTENCES
		{
			get
			{
				return 16384;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.TextUtils.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/TextUtils"));
			global::android.text.TextUtils._equals8460 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "equals", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Z");
			global::android.text.TextUtils._indexOf8461 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "indexOf", "(Ljava/lang/CharSequence;CI)I");
			global::android.text.TextUtils._indexOf8462 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "indexOf", "(Ljava/lang/CharSequence;CII)I");
			global::android.text.TextUtils._indexOf8463 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "indexOf", "(Ljava/lang/CharSequence;C)I");
			global::android.text.TextUtils._indexOf8464 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "indexOf", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)I");
			global::android.text.TextUtils._indexOf8465 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "indexOf", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;I)I");
			global::android.text.TextUtils._indexOf8466 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "indexOf", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;II)I");
			global::android.text.TextUtils._isEmpty8467 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "isEmpty", "(Ljava/lang/CharSequence;)Z");
			global::android.text.TextUtils._getChars8468 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "getChars", "(Ljava/lang/CharSequence;II[CI)V");
			global::android.text.TextUtils._regionMatches8469 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "regionMatches", "(Ljava/lang/CharSequence;ILjava/lang/CharSequence;II)Z");
			global::android.text.TextUtils._lastIndexOf8470 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "lastIndexOf", "(Ljava/lang/CharSequence;CI)I");
			global::android.text.TextUtils._lastIndexOf8471 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "lastIndexOf", "(Ljava/lang/CharSequence;CII)I");
			global::android.text.TextUtils._lastIndexOf8472 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "lastIndexOf", "(Ljava/lang/CharSequence;C)I");
			global::android.text.TextUtils._substring8473 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "substring", "(Ljava/lang/CharSequence;II)Ljava/lang/String;");
			global::android.text.TextUtils._concat8474 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "concat", "([Ljava/lang/CharSequence;)Ljava/lang/CharSequence;");
			global::android.text.TextUtils._replace8475 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "replace", "(Ljava/lang/CharSequence;[Ljava/lang/String;[Ljava/lang/CharSequence;)Ljava/lang/CharSequence;");
			global::android.text.TextUtils._split8476 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "split", "(Ljava/lang/String;Ljava/lang/String;)[Ljava/lang/String;");
			global::android.text.TextUtils._split8477 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "split", "(Ljava/lang/String;Ljava/util/regex/Pattern;)[Ljava/lang/String;");
			global::android.text.TextUtils._join8478 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "join", "(Ljava/lang/CharSequence;[Ljava/lang/Object;)Ljava/lang/String;");
			global::android.text.TextUtils._join8479 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "join", "(Ljava/lang/CharSequence;Ljava/lang/Iterable;)Ljava/lang/String;");
			global::android.text.TextUtils._ellipsize8480 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "ellipsize", "(Ljava/lang/CharSequence;Landroid/text/TextPaint;FLandroid/text/TextUtils$TruncateAt;)Ljava/lang/CharSequence;");
			global::android.text.TextUtils._ellipsize8481 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "ellipsize", "(Ljava/lang/CharSequence;Landroid/text/TextPaint;FLandroid/text/TextUtils$TruncateAt;ZLandroid/text/TextUtils$EllipsizeCallback;)Ljava/lang/CharSequence;");
			global::android.text.TextUtils._writeToParcel8482 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "writeToParcel", "(Ljava/lang/CharSequence;Landroid/os/Parcel;I)V");
			global::android.text.TextUtils._stringOrSpannedString8483 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "stringOrSpannedString", "(Ljava/lang/CharSequence;)Ljava/lang/CharSequence;");
			global::android.text.TextUtils._getTrimmedLength8484 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "getTrimmedLength", "(Ljava/lang/CharSequence;)I");
			global::android.text.TextUtils._getReverse8485 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "getReverse", "(Ljava/lang/CharSequence;II)Ljava/lang/CharSequence;");
			global::android.text.TextUtils._dumpSpans8486 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "dumpSpans", "(Ljava/lang/CharSequence;Landroid/util/Printer;Ljava/lang/String;)V");
			global::android.text.TextUtils._expandTemplate8487 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "expandTemplate", "(Ljava/lang/CharSequence;[Ljava/lang/CharSequence;)Ljava/lang/CharSequence;");
			global::android.text.TextUtils._getOffsetBefore8488 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "getOffsetBefore", "(Ljava/lang/CharSequence;I)I");
			global::android.text.TextUtils._getOffsetAfter8489 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "getOffsetAfter", "(Ljava/lang/CharSequence;I)I");
			global::android.text.TextUtils._copySpansFrom8490 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "copySpansFrom", "(Landroid/text/Spanned;IILjava/lang/Class;Landroid/text/Spannable;I)V");
			global::android.text.TextUtils._commaEllipsize8491 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "commaEllipsize", "(Ljava/lang/CharSequence;Landroid/text/TextPaint;FLjava/lang/String;Ljava/lang/String;)Ljava/lang/CharSequence;");
			global::android.text.TextUtils._htmlEncode8492 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "htmlEncode", "(Ljava/lang/String;)Ljava/lang/String;");
			global::android.text.TextUtils._isGraphic8493 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "isGraphic", "(Ljava/lang/CharSequence;)Z");
			global::android.text.TextUtils._isGraphic8494 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "isGraphic", "(C)Z");
			global::android.text.TextUtils._isDigitsOnly8495 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "isDigitsOnly", "(Ljava/lang/CharSequence;)Z");
			global::android.text.TextUtils._getCapsMode8496 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "getCapsMode", "(Ljava/lang/CharSequence;II)I");
		}
	}
}
