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
			internal static global::MonoJavaBridge.MethodId _ellipsized12981;
			 void android.text.TextUtils.EllipsizeCallback.ellipsized(int arg0, int arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.text.TextUtils.EllipsizeCallback_._ellipsized12981, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.TextUtils.EllipsizeCallback_.staticClass, global::android.text.TextUtils.EllipsizeCallback_._ellipsized12981, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.text.TextUtils.EllipsizeCallback_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/TextUtils$EllipsizeCallback"));
				global::android.text.TextUtils.EllipsizeCallback_._ellipsized12981 = @__env.GetMethodIDNoThrow(global::android.text.TextUtils.EllipsizeCallback_.staticClass, "ellipsized", "(II)V");
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
			internal static global::MonoJavaBridge.MethodId _iterator12982;
			public virtual global::java.util.Iterator iterator() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.TextUtils.SimpleStringSplitter._iterator12982)) as java.util.Iterator;
				else
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.TextUtils.SimpleStringSplitter.staticClass, global::android.text.TextUtils.SimpleStringSplitter._iterator12982)) as java.util.Iterator;
			}
			internal static global::MonoJavaBridge.MethodId _hasNext12983;
			public virtual bool hasNext() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.text.TextUtils.SimpleStringSplitter._hasNext12983);
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.text.TextUtils.SimpleStringSplitter.staticClass, global::android.text.TextUtils.SimpleStringSplitter._hasNext12983);
			}
			internal static global::MonoJavaBridge.MethodId _next12984;
			public virtual global::java.lang.Object next() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.text.TextUtils.SimpleStringSplitter._next12984)) as java.lang.Object;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.TextUtils.SimpleStringSplitter.staticClass, global::android.text.TextUtils.SimpleStringSplitter._next12984)) as java.lang.Object;
			}
			internal static global::MonoJavaBridge.MethodId _remove12985;
			public virtual void remove() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.text.TextUtils.SimpleStringSplitter._remove12985);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.TextUtils.SimpleStringSplitter.staticClass, global::android.text.TextUtils.SimpleStringSplitter._remove12985);
			}
			internal static global::MonoJavaBridge.MethodId _setString12986;
			public virtual void setString(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.text.TextUtils.SimpleStringSplitter._setString12986, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.TextUtils.SimpleStringSplitter.staticClass, global::android.text.TextUtils.SimpleStringSplitter._setString12986, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _SimpleStringSplitter12987;
			public SimpleStringSplitter(char arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.TextUtils.SimpleStringSplitter.staticClass, global::android.text.TextUtils.SimpleStringSplitter._SimpleStringSplitter12987, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.text.TextUtils.SimpleStringSplitter.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/TextUtils$SimpleStringSplitter"));
				global::android.text.TextUtils.SimpleStringSplitter._iterator12982 = @__env.GetMethodIDNoThrow(global::android.text.TextUtils.SimpleStringSplitter.staticClass, "iterator", "()Ljava/util/Iterator;");
				global::android.text.TextUtils.SimpleStringSplitter._hasNext12983 = @__env.GetMethodIDNoThrow(global::android.text.TextUtils.SimpleStringSplitter.staticClass, "hasNext", "()Z");
				global::android.text.TextUtils.SimpleStringSplitter._next12984 = @__env.GetMethodIDNoThrow(global::android.text.TextUtils.SimpleStringSplitter.staticClass, "next", "()Ljava/lang/Object;");
				global::android.text.TextUtils.SimpleStringSplitter._remove12985 = @__env.GetMethodIDNoThrow(global::android.text.TextUtils.SimpleStringSplitter.staticClass, "remove", "()V");
				global::android.text.TextUtils.SimpleStringSplitter._setString12986 = @__env.GetMethodIDNoThrow(global::android.text.TextUtils.SimpleStringSplitter.staticClass, "setString", "(Ljava/lang/String;)V");
				global::android.text.TextUtils.SimpleStringSplitter._SimpleStringSplitter12987 = @__env.GetMethodIDNoThrow(global::android.text.TextUtils.SimpleStringSplitter.staticClass, "<init>", "(C)V");
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
			internal static global::MonoJavaBridge.MethodId _setString12988;
			 void android.text.TextUtils.StringSplitter.setString(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.text.TextUtils.StringSplitter_._setString12988, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.TextUtils.StringSplitter_.staticClass, global::android.text.TextUtils.StringSplitter_._setString12988, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _iterator12989;
			 global::java.util.Iterator java.lang.Iterable.iterator() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.TextUtils.StringSplitter_._iterator12989)) as java.util.Iterator;
				else
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.TextUtils.StringSplitter_.staticClass, global::android.text.TextUtils.StringSplitter_._iterator12989)) as java.util.Iterator;
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.text.TextUtils.StringSplitter_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/TextUtils$StringSplitter"));
				global::android.text.TextUtils.StringSplitter_._setString12988 = @__env.GetMethodIDNoThrow(global::android.text.TextUtils.StringSplitter_.staticClass, "setString", "(Ljava/lang/String;)V");
				global::android.text.TextUtils.StringSplitter_._iterator12989 = @__env.GetMethodIDNoThrow(global::android.text.TextUtils.StringSplitter_.staticClass, "iterator", "()Ljava/util/Iterator;");
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
			internal static global::MonoJavaBridge.MethodId _values12990;
			public static global::android.text.TextUtils.TruncateAt[] values() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.text.TextUtils.TruncateAt>(@__env.CallStaticObjectMethod(android.text.TextUtils.TruncateAt.staticClass, global::android.text.TextUtils.TruncateAt._values12990)) as android.text.TextUtils.TruncateAt[];
			}
			internal static global::MonoJavaBridge.MethodId _valueOf12991;
			public static global::android.text.TextUtils.TruncateAt valueOf(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.text.TextUtils.TruncateAt.staticClass, global::android.text.TextUtils.TruncateAt._valueOf12991, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.text.TextUtils.TruncateAt;
			}
			internal static global::MonoJavaBridge.FieldId _END12992;
			public static global::android.text.TextUtils.TruncateAt END
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.text.TextUtils.TruncateAt.staticClass, _END12992)) as android.text.TextUtils.TruncateAt;
				}
			}
			internal static global::MonoJavaBridge.FieldId _MARQUEE12993;
			public static global::android.text.TextUtils.TruncateAt MARQUEE
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.text.TextUtils.TruncateAt.staticClass, _MARQUEE12993)) as android.text.TextUtils.TruncateAt;
				}
			}
			internal static global::MonoJavaBridge.FieldId _MIDDLE12994;
			public static global::android.text.TextUtils.TruncateAt MIDDLE
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.text.TextUtils.TruncateAt.staticClass, _MIDDLE12994)) as android.text.TextUtils.TruncateAt;
				}
			}
			internal static global::MonoJavaBridge.FieldId _START12995;
			public static global::android.text.TextUtils.TruncateAt START
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.text.TextUtils.TruncateAt.staticClass, _START12995)) as android.text.TextUtils.TruncateAt;
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.text.TextUtils.TruncateAt.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/TextUtils$TruncateAt"));
				global::android.text.TextUtils.TruncateAt._values12990 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.TruncateAt.staticClass, "values", "()[Landroid/text/TextUtils/TruncateAt;");
				global::android.text.TextUtils.TruncateAt._valueOf12991 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.TruncateAt.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/text/TextUtils$TruncateAt;");
				global::android.text.TextUtils.TruncateAt._END12992 = @__env.GetStaticFieldIDNoThrow(global::android.text.TextUtils.TruncateAt.staticClass, "END", "Landroid/text/TextUtils$TruncateAt;");
				global::android.text.TextUtils.TruncateAt._MARQUEE12993 = @__env.GetStaticFieldIDNoThrow(global::android.text.TextUtils.TruncateAt.staticClass, "MARQUEE", "Landroid/text/TextUtils$TruncateAt;");
				global::android.text.TextUtils.TruncateAt._MIDDLE12994 = @__env.GetStaticFieldIDNoThrow(global::android.text.TextUtils.TruncateAt.staticClass, "MIDDLE", "Landroid/text/TextUtils$TruncateAt;");
				global::android.text.TextUtils.TruncateAt._START12995 = @__env.GetStaticFieldIDNoThrow(global::android.text.TextUtils.TruncateAt.staticClass, "START", "Landroid/text/TextUtils$TruncateAt;");
			}
		}
		internal static global::MonoJavaBridge.MethodId _equals12996;
		public static bool equals(java.lang.CharSequence arg0, java.lang.CharSequence arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._equals12996, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _indexOf12997;
		public static int indexOf(java.lang.CharSequence arg0, char arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._indexOf12997, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _indexOf12998;
		public static int indexOf(java.lang.CharSequence arg0, char arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._indexOf12998, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _indexOf12999;
		public static int indexOf(java.lang.CharSequence arg0, char arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._indexOf12999, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _indexOf13000;
		public static int indexOf(java.lang.CharSequence arg0, java.lang.CharSequence arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._indexOf13000, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _indexOf13001;
		public static int indexOf(java.lang.CharSequence arg0, java.lang.CharSequence arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._indexOf13001, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _indexOf13002;
		public static int indexOf(java.lang.CharSequence arg0, java.lang.CharSequence arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._indexOf13002, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty13003;
		public static bool isEmpty(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._isEmpty13003, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getChars13004;
		public static void getChars(java.lang.CharSequence arg0, int arg1, int arg2, char[] arg3, int arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._getChars13004, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _regionMatches13005;
		public static bool regionMatches(java.lang.CharSequence arg0, int arg1, java.lang.CharSequence arg2, int arg3, int arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._regionMatches13005, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _lastIndexOf13006;
		public static int lastIndexOf(java.lang.CharSequence arg0, char arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._lastIndexOf13006, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _lastIndexOf13007;
		public static int lastIndexOf(java.lang.CharSequence arg0, char arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._lastIndexOf13007, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _lastIndexOf13008;
		public static int lastIndexOf(java.lang.CharSequence arg0, char arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._lastIndexOf13008, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _substring13009;
		public static global::java.lang.String substring(java.lang.CharSequence arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._substring13009, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _concat13010;
		public static global::java.lang.CharSequence concat(java.lang.CharSequence[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallStaticObjectMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._concat13010, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _replace13011;
		public static global::java.lang.CharSequence replace(java.lang.CharSequence arg0, java.lang.String[] arg1, java.lang.CharSequence[] arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallStaticObjectMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._replace13011, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _split13012;
		public static global::java.lang.String[] split(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallStaticObjectMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._split13012, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _split13013;
		public static global::java.lang.String[] split(java.lang.String arg0, java.util.regex.Pattern arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallStaticObjectMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._split13013, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _join13014;
		public static global::java.lang.String join(java.lang.CharSequence arg0, java.lang.Object[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._join13014, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _join13015;
		public static global::java.lang.String join(java.lang.CharSequence arg0, java.lang.Iterable arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._join13015, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _ellipsize13016;
		public static global::java.lang.CharSequence ellipsize(java.lang.CharSequence arg0, android.text.TextPaint arg1, float arg2, android.text.TextUtils.TruncateAt arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallStaticObjectMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._ellipsize13016, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _ellipsize13017;
		public static global::java.lang.CharSequence ellipsize(java.lang.CharSequence arg0, android.text.TextPaint arg1, float arg2, android.text.TextUtils.TruncateAt arg3, bool arg4, android.text.TextUtils.EllipsizeCallback arg5) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallStaticObjectMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._ellipsize13017, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5))) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel13018;
		public static void writeToParcel(java.lang.CharSequence arg0, android.os.Parcel arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._writeToParcel13018, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _stringOrSpannedString13019;
		public static global::java.lang.CharSequence stringOrSpannedString(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallStaticObjectMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._stringOrSpannedString13019, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _getTrimmedLength13020;
		public static int getTrimmedLength(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._getTrimmedLength13020, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getReverse13021;
		public static global::java.lang.CharSequence getReverse(java.lang.CharSequence arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallStaticObjectMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._getReverse13021, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _dumpSpans13022;
		public static void dumpSpans(java.lang.CharSequence arg0, android.util.Printer arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._dumpSpans13022, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _expandTemplate13023;
		public static global::java.lang.CharSequence expandTemplate(java.lang.CharSequence arg0, java.lang.CharSequence[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallStaticObjectMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._expandTemplate13023, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _getOffsetBefore13024;
		public static int getOffsetBefore(java.lang.CharSequence arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._getOffsetBefore13024, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getOffsetAfter13025;
		public static int getOffsetAfter(java.lang.CharSequence arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._getOffsetAfter13025, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _copySpansFrom13026;
		public static void copySpansFrom(android.text.Spanned arg0, int arg1, int arg2, java.lang.Class arg3, android.text.Spannable arg4, int arg5) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._copySpansFrom13026, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _commaEllipsize13027;
		public static global::java.lang.CharSequence commaEllipsize(java.lang.CharSequence arg0, android.text.TextPaint arg1, float arg2, java.lang.String arg3, java.lang.String arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallStaticObjectMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._commaEllipsize13027, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _htmlEncode13028;
		public static global::java.lang.String htmlEncode(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._htmlEncode13028, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isGraphic13029;
		public static bool isGraphic(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._isGraphic13029, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isGraphic13030;
		public static bool isGraphic(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._isGraphic13030, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isDigitsOnly13031;
		public static bool isDigitsOnly(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._isDigitsOnly13031, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getCapsMode13032;
		public static int getCapsMode(java.lang.CharSequence arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._getCapsMode13032, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.FieldId _CHAR_SEQUENCE_CREATOR13033;
		public static global::android.os.Parcelable_Creator CHAR_SEQUENCE_CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.text.TextUtils.staticClass, _CHAR_SEQUENCE_CREATOR13033)) as android.os.Parcelable_Creator;
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
			global::android.text.TextUtils._equals12996 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "equals", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Z");
			global::android.text.TextUtils._indexOf12997 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "indexOf", "(Ljava/lang/CharSequence;CI)I");
			global::android.text.TextUtils._indexOf12998 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "indexOf", "(Ljava/lang/CharSequence;CII)I");
			global::android.text.TextUtils._indexOf12999 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "indexOf", "(Ljava/lang/CharSequence;C)I");
			global::android.text.TextUtils._indexOf13000 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "indexOf", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)I");
			global::android.text.TextUtils._indexOf13001 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "indexOf", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;I)I");
			global::android.text.TextUtils._indexOf13002 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "indexOf", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;II)I");
			global::android.text.TextUtils._isEmpty13003 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "isEmpty", "(Ljava/lang/CharSequence;)Z");
			global::android.text.TextUtils._getChars13004 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "getChars", "(Ljava/lang/CharSequence;II[CI)V");
			global::android.text.TextUtils._regionMatches13005 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "regionMatches", "(Ljava/lang/CharSequence;ILjava/lang/CharSequence;II)Z");
			global::android.text.TextUtils._lastIndexOf13006 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "lastIndexOf", "(Ljava/lang/CharSequence;CI)I");
			global::android.text.TextUtils._lastIndexOf13007 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "lastIndexOf", "(Ljava/lang/CharSequence;CII)I");
			global::android.text.TextUtils._lastIndexOf13008 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "lastIndexOf", "(Ljava/lang/CharSequence;C)I");
			global::android.text.TextUtils._substring13009 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "substring", "(Ljava/lang/CharSequence;II)Ljava/lang/String;");
			global::android.text.TextUtils._concat13010 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "concat", "([Ljava/lang/CharSequence;)Ljava/lang/CharSequence;");
			global::android.text.TextUtils._replace13011 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "replace", "(Ljava/lang/CharSequence;[Ljava/lang/String;[Ljava/lang/CharSequence;)Ljava/lang/CharSequence;");
			global::android.text.TextUtils._split13012 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "split", "(Ljava/lang/String;Ljava/lang/String;)[Ljava/lang/String;");
			global::android.text.TextUtils._split13013 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "split", "(Ljava/lang/String;Ljava/util/regex/Pattern;)[Ljava/lang/String;");
			global::android.text.TextUtils._join13014 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "join", "(Ljava/lang/CharSequence;[Ljava/lang/Object;)Ljava/lang/String;");
			global::android.text.TextUtils._join13015 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "join", "(Ljava/lang/CharSequence;Ljava/lang/Iterable;)Ljava/lang/String;");
			global::android.text.TextUtils._ellipsize13016 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "ellipsize", "(Ljava/lang/CharSequence;Landroid/text/TextPaint;FLandroid/text/TextUtils$TruncateAt;)Ljava/lang/CharSequence;");
			global::android.text.TextUtils._ellipsize13017 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "ellipsize", "(Ljava/lang/CharSequence;Landroid/text/TextPaint;FLandroid/text/TextUtils$TruncateAt;ZLandroid/text/TextUtils$EllipsizeCallback;)Ljava/lang/CharSequence;");
			global::android.text.TextUtils._writeToParcel13018 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "writeToParcel", "(Ljava/lang/CharSequence;Landroid/os/Parcel;I)V");
			global::android.text.TextUtils._stringOrSpannedString13019 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "stringOrSpannedString", "(Ljava/lang/CharSequence;)Ljava/lang/CharSequence;");
			global::android.text.TextUtils._getTrimmedLength13020 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "getTrimmedLength", "(Ljava/lang/CharSequence;)I");
			global::android.text.TextUtils._getReverse13021 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "getReverse", "(Ljava/lang/CharSequence;II)Ljava/lang/CharSequence;");
			global::android.text.TextUtils._dumpSpans13022 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "dumpSpans", "(Ljava/lang/CharSequence;Landroid/util/Printer;Ljava/lang/String;)V");
			global::android.text.TextUtils._expandTemplate13023 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "expandTemplate", "(Ljava/lang/CharSequence;[Ljava/lang/CharSequence;)Ljava/lang/CharSequence;");
			global::android.text.TextUtils._getOffsetBefore13024 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "getOffsetBefore", "(Ljava/lang/CharSequence;I)I");
			global::android.text.TextUtils._getOffsetAfter13025 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "getOffsetAfter", "(Ljava/lang/CharSequence;I)I");
			global::android.text.TextUtils._copySpansFrom13026 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "copySpansFrom", "(Landroid/text/Spanned;IILjava/lang/Class;Landroid/text/Spannable;I)V");
			global::android.text.TextUtils._commaEllipsize13027 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "commaEllipsize", "(Ljava/lang/CharSequence;Landroid/text/TextPaint;FLjava/lang/String;Ljava/lang/String;)Ljava/lang/CharSequence;");
			global::android.text.TextUtils._htmlEncode13028 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "htmlEncode", "(Ljava/lang/String;)Ljava/lang/String;");
			global::android.text.TextUtils._isGraphic13029 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "isGraphic", "(Ljava/lang/CharSequence;)Z");
			global::android.text.TextUtils._isGraphic13030 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "isGraphic", "(C)Z");
			global::android.text.TextUtils._isDigitsOnly13031 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "isDigitsOnly", "(Ljava/lang/CharSequence;)Z");
			global::android.text.TextUtils._getCapsMode13032 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "getCapsMode", "(Ljava/lang/CharSequence;II)I");
			global::android.text.TextUtils._CHAR_SEQUENCE_CREATOR13033 = @__env.GetStaticFieldIDNoThrow(global::android.text.TextUtils.staticClass, "CHAR_SEQUENCE_CREATOR", "Landroid/os/Parcelable$Creator;");
		}
	}
}
