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
		public partial interface EllipsizeCallback  : global::MonoJavaBridge.IJavaObject 
		{
			void ellipsized(int arg0, int arg1);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.text.TextUtils.EllipsizeCallback))]
		internal sealed partial class EllipsizeCallback_ : java.lang.Object, EllipsizeCallback
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static EllipsizeCallback_()
			{
				InitJNI();
			}
			internal EllipsizeCallback_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _ellipsized13042;
			void android.text.TextUtils.EllipsizeCallback.ellipsized(int arg0, int arg1)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.text.TextUtils.EllipsizeCallback_._ellipsized13042, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.TextUtils.EllipsizeCallback_.staticClass, global::android.text.TextUtils.EllipsizeCallback_._ellipsized13042, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.text.TextUtils.EllipsizeCallback_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/TextUtils$EllipsizeCallback"));
				global::android.text.TextUtils.EllipsizeCallback_._ellipsized13042 = @__env.GetMethodIDNoThrow(global::android.text.TextUtils.EllipsizeCallback_.staticClass, "ellipsized", "(II)V");
			}
		}

		public delegate void EllipsizeCallbackDelegate(int arg0, int arg1);

		internal partial class EllipsizeCallbackDelegateWrapper : java.lang.Object, EllipsizeCallback
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static EllipsizeCallbackDelegateWrapper()
			{
				InitJNI();
			}
			protected EllipsizeCallbackDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _EllipsizeCallbackDelegateWrapper13043;
			public EllipsizeCallbackDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.TextUtils.EllipsizeCallbackDelegateWrapper.staticClass, global::android.text.TextUtils.EllipsizeCallbackDelegateWrapper._EllipsizeCallbackDelegateWrapper13043);
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.text.TextUtils.EllipsizeCallbackDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/TextUtils_EllipsizeCallbackDelegateWrapper"));
				global::android.text.TextUtils.EllipsizeCallbackDelegateWrapper._EllipsizeCallbackDelegateWrapper13043 = @__env.GetMethodIDNoThrow(global::android.text.TextUtils.EllipsizeCallbackDelegateWrapper.staticClass, "<init>", "()V");
			}
		}
		internal partial class EllipsizeCallbackDelegateWrapper
		{
			private EllipsizeCallbackDelegate myDelegate;
			public void ellipsized(int arg0, int arg1)
			{
				myDelegate(arg0, arg1);
			}
			public static implicit operator EllipsizeCallbackDelegateWrapper(EllipsizeCallbackDelegate d)
			{
				global::android.text.TextUtils.EllipsizeCallbackDelegateWrapper ret = new global::android.text.TextUtils.EllipsizeCallbackDelegateWrapper();
				ret.myDelegate = d;
				global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
				return ret;
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
			public global::System.Collections.IEnumerator GetEnumerator()
			{
				return global::java.lang.IterableHelper.WrapIterator(iterator());
			}
			internal static global::MonoJavaBridge.MethodId _iterator13044;
			public virtual global::java.util.Iterator iterator()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.TextUtils.SimpleStringSplitter._iterator13044)) as java.util.Iterator;
				else
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.TextUtils.SimpleStringSplitter.staticClass, global::android.text.TextUtils.SimpleStringSplitter._iterator13044)) as java.util.Iterator;
			}
			internal static global::MonoJavaBridge.MethodId _hasNext13045;
			public virtual bool hasNext()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.text.TextUtils.SimpleStringSplitter._hasNext13045);
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.text.TextUtils.SimpleStringSplitter.staticClass, global::android.text.TextUtils.SimpleStringSplitter._hasNext13045);
			}
			internal static global::MonoJavaBridge.MethodId _next13046;
			public virtual global::java.lang.Object next()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.text.TextUtils.SimpleStringSplitter._next13046)) as java.lang.Object;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.TextUtils.SimpleStringSplitter.staticClass, global::android.text.TextUtils.SimpleStringSplitter._next13046)) as java.lang.Object;
			}
			internal static global::MonoJavaBridge.MethodId _remove13047;
			public virtual void remove()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.text.TextUtils.SimpleStringSplitter._remove13047);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.TextUtils.SimpleStringSplitter.staticClass, global::android.text.TextUtils.SimpleStringSplitter._remove13047);
			}
			public new global::java.lang.String String
			{
				set
				{
					setString(value);
				}
			}
			internal static global::MonoJavaBridge.MethodId _setString13048;
			public virtual void setString(java.lang.String arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.text.TextUtils.SimpleStringSplitter._setString13048, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.TextUtils.SimpleStringSplitter.staticClass, global::android.text.TextUtils.SimpleStringSplitter._setString13048, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _SimpleStringSplitter13049;
			public SimpleStringSplitter(char arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.TextUtils.SimpleStringSplitter.staticClass, global::android.text.TextUtils.SimpleStringSplitter._SimpleStringSplitter13049, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.text.TextUtils.SimpleStringSplitter.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/TextUtils$SimpleStringSplitter"));
				global::android.text.TextUtils.SimpleStringSplitter._iterator13044 = @__env.GetMethodIDNoThrow(global::android.text.TextUtils.SimpleStringSplitter.staticClass, "iterator", "()Ljava/util/Iterator;");
				global::android.text.TextUtils.SimpleStringSplitter._hasNext13045 = @__env.GetMethodIDNoThrow(global::android.text.TextUtils.SimpleStringSplitter.staticClass, "hasNext", "()Z");
				global::android.text.TextUtils.SimpleStringSplitter._next13046 = @__env.GetMethodIDNoThrow(global::android.text.TextUtils.SimpleStringSplitter.staticClass, "next", "()Ljava/lang/Object;");
				global::android.text.TextUtils.SimpleStringSplitter._remove13047 = @__env.GetMethodIDNoThrow(global::android.text.TextUtils.SimpleStringSplitter.staticClass, "remove", "()V");
				global::android.text.TextUtils.SimpleStringSplitter._setString13048 = @__env.GetMethodIDNoThrow(global::android.text.TextUtils.SimpleStringSplitter.staticClass, "setString", "(Ljava/lang/String;)V");
				global::android.text.TextUtils.SimpleStringSplitter._SimpleStringSplitter13049 = @__env.GetMethodIDNoThrow(global::android.text.TextUtils.SimpleStringSplitter.staticClass, "<init>", "(C)V");
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.text.TextUtils.StringSplitter_))]
		public partial interface StringSplitter : java.lang.Iterable
		{
			void setString(java.lang.String arg0);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.text.TextUtils.StringSplitter))]
		internal sealed partial class StringSplitter_ : java.lang.Object, StringSplitter
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static StringSplitter_()
			{
				InitJNI();
			}
			internal StringSplitter_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _setString13050;
			void android.text.TextUtils.StringSplitter.setString(java.lang.String arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.text.TextUtils.StringSplitter_._setString13050, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.TextUtils.StringSplitter_.staticClass, global::android.text.TextUtils.StringSplitter_._setString13050, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			public global::System.Collections.IEnumerator GetEnumerator()
			{
				return global::java.lang.IterableHelper.WrapIterator(((global::java.lang.Iterable)this).iterator());
			}
			internal static global::MonoJavaBridge.MethodId _iterator13051;
			global::java.util.Iterator java.lang.Iterable.iterator()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.TextUtils.StringSplitter_._iterator13051)) as java.util.Iterator;
				else
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.TextUtils.StringSplitter_.staticClass, global::android.text.TextUtils.StringSplitter_._iterator13051)) as java.util.Iterator;
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.text.TextUtils.StringSplitter_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/TextUtils$StringSplitter"));
				global::android.text.TextUtils.StringSplitter_._setString13050 = @__env.GetMethodIDNoThrow(global::android.text.TextUtils.StringSplitter_.staticClass, "setString", "(Ljava/lang/String;)V");
				global::android.text.TextUtils.StringSplitter_._iterator13051 = @__env.GetMethodIDNoThrow(global::android.text.TextUtils.StringSplitter_.staticClass, "iterator", "()Ljava/util/Iterator;");
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
			internal static global::MonoJavaBridge.MethodId _values13052;
			public static global::android.text.TextUtils.TruncateAt[] values()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.text.TextUtils.TruncateAt>(@__env.CallStaticObjectMethod(android.text.TextUtils.TruncateAt.staticClass, global::android.text.TextUtils.TruncateAt._values13052)) as android.text.TextUtils.TruncateAt[];
			}
			internal static global::MonoJavaBridge.MethodId _valueOf13053;
			public static global::android.text.TextUtils.TruncateAt valueOf(java.lang.String arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.text.TextUtils.TruncateAt>(@__env.CallStaticObjectMethod(android.text.TextUtils.TruncateAt.staticClass, global::android.text.TextUtils.TruncateAt._valueOf13053, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.text.TextUtils.TruncateAt;
			}
			internal static global::MonoJavaBridge.FieldId _END13054;
			public static global::android.text.TextUtils.TruncateAt END
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.text.TextUtils.TruncateAt>(@__env.GetStaticObjectField(global::android.text.TextUtils.TruncateAt.staticClass, _END13054)) as android.text.TextUtils.TruncateAt;
				}
			}
			internal static global::MonoJavaBridge.FieldId _MARQUEE13055;
			public static global::android.text.TextUtils.TruncateAt MARQUEE
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.text.TextUtils.TruncateAt>(@__env.GetStaticObjectField(global::android.text.TextUtils.TruncateAt.staticClass, _MARQUEE13055)) as android.text.TextUtils.TruncateAt;
				}
			}
			internal static global::MonoJavaBridge.FieldId _MIDDLE13056;
			public static global::android.text.TextUtils.TruncateAt MIDDLE
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.text.TextUtils.TruncateAt>(@__env.GetStaticObjectField(global::android.text.TextUtils.TruncateAt.staticClass, _MIDDLE13056)) as android.text.TextUtils.TruncateAt;
				}
			}
			internal static global::MonoJavaBridge.FieldId _START13057;
			public static global::android.text.TextUtils.TruncateAt START
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.text.TextUtils.TruncateAt>(@__env.GetStaticObjectField(global::android.text.TextUtils.TruncateAt.staticClass, _START13057)) as android.text.TextUtils.TruncateAt;
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.text.TextUtils.TruncateAt.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/TextUtils$TruncateAt"));
				global::android.text.TextUtils.TruncateAt._values13052 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.TruncateAt.staticClass, "values", "()[Landroid/text/TextUtils/TruncateAt;");
				global::android.text.TextUtils.TruncateAt._valueOf13053 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.TruncateAt.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/text/TextUtils$TruncateAt;");
				global::android.text.TextUtils.TruncateAt._END13054 = @__env.GetStaticFieldIDNoThrow(global::android.text.TextUtils.TruncateAt.staticClass, "END", "Landroid/text/TextUtils$TruncateAt;");
				global::android.text.TextUtils.TruncateAt._MARQUEE13055 = @__env.GetStaticFieldIDNoThrow(global::android.text.TextUtils.TruncateAt.staticClass, "MARQUEE", "Landroid/text/TextUtils$TruncateAt;");
				global::android.text.TextUtils.TruncateAt._MIDDLE13056 = @__env.GetStaticFieldIDNoThrow(global::android.text.TextUtils.TruncateAt.staticClass, "MIDDLE", "Landroid/text/TextUtils$TruncateAt;");
				global::android.text.TextUtils.TruncateAt._START13057 = @__env.GetStaticFieldIDNoThrow(global::android.text.TextUtils.TruncateAt.staticClass, "START", "Landroid/text/TextUtils$TruncateAt;");
			}
		}
		internal static global::MonoJavaBridge.MethodId _equals13058;
		public static bool equals(java.lang.CharSequence arg0, java.lang.CharSequence arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._equals13058, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public static bool equals(string arg0, string arg1)
		{
			return equals((global::java.lang.CharSequence)(global::java.lang.String)arg0, (global::java.lang.CharSequence)(global::java.lang.String)arg1);
		}
		internal static global::MonoJavaBridge.MethodId _indexOf13059;
		public static int indexOf(java.lang.CharSequence arg0, char arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._indexOf13059, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public static int indexOf(string arg0, char arg1, int arg2)
		{
			return indexOf((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2);
		}
		internal static global::MonoJavaBridge.MethodId _indexOf13060;
		public static int indexOf(java.lang.CharSequence arg0, char arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._indexOf13060, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		public static int indexOf(string arg0, char arg1, int arg2, int arg3)
		{
			return indexOf((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2, arg3);
		}
		internal static global::MonoJavaBridge.MethodId _indexOf13061;
		public static int indexOf(java.lang.CharSequence arg0, char arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._indexOf13061, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public static int indexOf(string arg0, char arg1)
		{
			return indexOf((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
		}
		internal static global::MonoJavaBridge.MethodId _indexOf13062;
		public static int indexOf(java.lang.CharSequence arg0, java.lang.CharSequence arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._indexOf13062, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public static int indexOf(string arg0, string arg1)
		{
			return indexOf((global::java.lang.CharSequence)(global::java.lang.String)arg0, (global::java.lang.CharSequence)(global::java.lang.String)arg1);
		}
		internal static global::MonoJavaBridge.MethodId _indexOf13063;
		public static int indexOf(java.lang.CharSequence arg0, java.lang.CharSequence arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._indexOf13063, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public static int indexOf(string arg0, string arg1, int arg2)
		{
			return indexOf((global::java.lang.CharSequence)(global::java.lang.String)arg0, (global::java.lang.CharSequence)(global::java.lang.String)arg1, arg2);
		}
		internal static global::MonoJavaBridge.MethodId _indexOf13064;
		public static int indexOf(java.lang.CharSequence arg0, java.lang.CharSequence arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._indexOf13064, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		public static int indexOf(string arg0, string arg1, int arg2, int arg3)
		{
			return indexOf((global::java.lang.CharSequence)(global::java.lang.String)arg0, (global::java.lang.CharSequence)(global::java.lang.String)arg1, arg2, arg3);
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty13065;
		public static bool isEmpty(java.lang.CharSequence arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._isEmpty13065, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public static bool isEmpty(string arg0)
		{
			return isEmpty((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _getChars13066;
		public static void getChars(java.lang.CharSequence arg0, int arg1, int arg2, char[] arg3, int arg4)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._getChars13066, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		public static void getChars(string arg0, int arg1, int arg2, char[] arg3, int arg4)
		{
			getChars((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2, arg3, arg4);
		}
		internal static global::MonoJavaBridge.MethodId _regionMatches13067;
		public static bool regionMatches(java.lang.CharSequence arg0, int arg1, java.lang.CharSequence arg2, int arg3, int arg4)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._regionMatches13067, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		public static bool regionMatches(string arg0, int arg1, string arg2, int arg3, int arg4)
		{
			return regionMatches((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, (global::java.lang.CharSequence)(global::java.lang.String)arg2, arg3, arg4);
		}
		internal static global::MonoJavaBridge.MethodId _lastIndexOf13068;
		public static int lastIndexOf(java.lang.CharSequence arg0, char arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._lastIndexOf13068, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public static int lastIndexOf(string arg0, char arg1, int arg2)
		{
			return lastIndexOf((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2);
		}
		internal static global::MonoJavaBridge.MethodId _lastIndexOf13069;
		public static int lastIndexOf(java.lang.CharSequence arg0, char arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._lastIndexOf13069, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		public static int lastIndexOf(string arg0, char arg1, int arg2, int arg3)
		{
			return lastIndexOf((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2, arg3);
		}
		internal static global::MonoJavaBridge.MethodId _lastIndexOf13070;
		public static int lastIndexOf(java.lang.CharSequence arg0, char arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._lastIndexOf13070, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public static int lastIndexOf(string arg0, char arg1)
		{
			return lastIndexOf((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
		}
		internal static global::MonoJavaBridge.MethodId _substring13071;
		public static global::java.lang.String substring(java.lang.CharSequence arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._substring13071, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.String;
		}
		public static java.lang.String substring(string arg0, int arg1, int arg2)
		{
			return substring((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2);
		}
		internal static global::MonoJavaBridge.MethodId _concat13072;
		public static global::java.lang.CharSequence concat(java.lang.CharSequence[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallStaticObjectMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._concat13072, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _replace13073;
		public static global::java.lang.CharSequence replace(java.lang.CharSequence arg0, java.lang.String[] arg1, java.lang.CharSequence[] arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallStaticObjectMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._replace13073, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.CharSequence;
		}
		public static java.lang.CharSequence replace(string arg0, java.lang.String[] arg1, java.lang.CharSequence[] arg2)
		{
			return replace((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2);
		}
		internal static global::MonoJavaBridge.MethodId _split13074;
		public static global::java.lang.String[] split(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallStaticObjectMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._split13074, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _split13075;
		public static global::java.lang.String[] split(java.lang.String arg0, java.util.regex.Pattern arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallStaticObjectMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._split13075, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _join13076;
		public static global::java.lang.String join(java.lang.CharSequence arg0, java.lang.Object[] arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._join13076, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		public static java.lang.String join(string arg0, java.lang.Object[] arg1)
		{
			return join((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
		}
		internal static global::MonoJavaBridge.MethodId _join13077;
		public static global::java.lang.String join(java.lang.CharSequence arg0, java.lang.Iterable arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._join13077, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		public static java.lang.String join(string arg0, java.lang.Iterable arg1)
		{
			return join((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
		}
		internal static global::MonoJavaBridge.MethodId _ellipsize13078;
		public static global::java.lang.CharSequence ellipsize(java.lang.CharSequence arg0, android.text.TextPaint arg1, float arg2, android.text.TextUtils.TruncateAt arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallStaticObjectMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._ellipsize13078, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.lang.CharSequence;
		}
		public static java.lang.CharSequence ellipsize(string arg0, android.text.TextPaint arg1, float arg2, android.text.TextUtils.TruncateAt arg3)
		{
			return ellipsize((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2, arg3);
		}
		internal static global::MonoJavaBridge.MethodId _ellipsize13079;
		public static global::java.lang.CharSequence ellipsize(java.lang.CharSequence arg0, android.text.TextPaint arg1, float arg2, android.text.TextUtils.TruncateAt arg3, bool arg4, android.text.TextUtils.EllipsizeCallback arg5)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallStaticObjectMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._ellipsize13079, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5))) as java.lang.CharSequence;
		}
		public static java.lang.CharSequence ellipsize(string arg0, android.text.TextPaint arg1, float arg2, android.text.TextUtils.TruncateAt arg3, bool arg4, global::android.text.TextUtils.EllipsizeCallbackDelegate arg5)
		{
			return ellipsize((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2, arg3, arg4, (global::android.text.TextUtils.EllipsizeCallbackDelegateWrapper)arg5);
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel13080;
		public static void writeToParcel(java.lang.CharSequence arg0, android.os.Parcel arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._writeToParcel13080, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public static void writeToParcel(string arg0, android.os.Parcel arg1, int arg2)
		{
			writeToParcel((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2);
		}
		internal static global::MonoJavaBridge.MethodId _stringOrSpannedString13081;
		public static global::java.lang.CharSequence stringOrSpannedString(java.lang.CharSequence arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallStaticObjectMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._stringOrSpannedString13081, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence;
		}
		public static java.lang.CharSequence stringOrSpannedString(string arg0)
		{
			return stringOrSpannedString((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _getTrimmedLength13082;
		public static int getTrimmedLength(java.lang.CharSequence arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._getTrimmedLength13082, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public static int getTrimmedLength(string arg0)
		{
			return getTrimmedLength((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _getReverse13083;
		public static global::java.lang.CharSequence getReverse(java.lang.CharSequence arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallStaticObjectMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._getReverse13083, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.CharSequence;
		}
		public static java.lang.CharSequence getReverse(string arg0, int arg1, int arg2)
		{
			return getReverse((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2);
		}
		internal static global::MonoJavaBridge.MethodId _dumpSpans13084;
		public static void dumpSpans(java.lang.CharSequence arg0, android.util.Printer arg1, java.lang.String arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._dumpSpans13084, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public static void dumpSpans(string arg0, global::android.util.PrinterDelegate arg1, java.lang.String arg2)
		{
			dumpSpans((global::java.lang.CharSequence)(global::java.lang.String)arg0, (global::android.util.PrinterDelegateWrapper)arg1, arg2);
		}
		internal static global::MonoJavaBridge.MethodId _expandTemplate13085;
		public static global::java.lang.CharSequence expandTemplate(java.lang.CharSequence arg0, java.lang.CharSequence[] arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallStaticObjectMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._expandTemplate13085, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.CharSequence;
		}
		public static java.lang.CharSequence expandTemplate(string arg0, java.lang.CharSequence[] arg1)
		{
			return expandTemplate((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
		}
		internal static global::MonoJavaBridge.MethodId _getOffsetBefore13086;
		public static int getOffsetBefore(java.lang.CharSequence arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._getOffsetBefore13086, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public static int getOffsetBefore(string arg0, int arg1)
		{
			return getOffsetBefore((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
		}
		internal static global::MonoJavaBridge.MethodId _getOffsetAfter13087;
		public static int getOffsetAfter(java.lang.CharSequence arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._getOffsetAfter13087, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public static int getOffsetAfter(string arg0, int arg1)
		{
			return getOffsetAfter((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
		}
		internal static global::MonoJavaBridge.MethodId _copySpansFrom13088;
		public static void copySpansFrom(android.text.Spanned arg0, int arg1, int arg2, java.lang.Class arg3, android.text.Spannable arg4, int arg5)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._copySpansFrom13088, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _commaEllipsize13089;
		public static global::java.lang.CharSequence commaEllipsize(java.lang.CharSequence arg0, android.text.TextPaint arg1, float arg2, java.lang.String arg3, java.lang.String arg4)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallStaticObjectMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._commaEllipsize13089, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as java.lang.CharSequence;
		}
		public static java.lang.CharSequence commaEllipsize(string arg0, android.text.TextPaint arg1, float arg2, java.lang.String arg3, java.lang.String arg4)
		{
			return commaEllipsize((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2, arg3, arg4);
		}
		internal static global::MonoJavaBridge.MethodId _htmlEncode13090;
		public static global::java.lang.String htmlEncode(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._htmlEncode13090, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isGraphic13091;
		public static bool isGraphic(java.lang.CharSequence arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._isGraphic13091, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public static bool isGraphic(string arg0)
		{
			return isGraphic((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _isGraphic13092;
		public static bool isGraphic(char arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._isGraphic13092, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isDigitsOnly13093;
		public static bool isDigitsOnly(java.lang.CharSequence arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._isDigitsOnly13093, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public static bool isDigitsOnly(string arg0)
		{
			return isDigitsOnly((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _getCapsMode13094;
		public static int getCapsMode(java.lang.CharSequence arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._getCapsMode13094, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public static int getCapsMode(string arg0, int arg1, int arg2)
		{
			return getCapsMode((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2);
		}
		internal static global::MonoJavaBridge.FieldId _CHAR_SEQUENCE_CREATOR13095;
		public static global::android.os.Parcelable_Creator CHAR_SEQUENCE_CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.text.TextUtils.staticClass, _CHAR_SEQUENCE_CREATOR13095)) as android.os.Parcelable_Creator;
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
			global::android.text.TextUtils._equals13058 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "equals", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Z");
			global::android.text.TextUtils._indexOf13059 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "indexOf", "(Ljava/lang/CharSequence;CI)I");
			global::android.text.TextUtils._indexOf13060 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "indexOf", "(Ljava/lang/CharSequence;CII)I");
			global::android.text.TextUtils._indexOf13061 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "indexOf", "(Ljava/lang/CharSequence;C)I");
			global::android.text.TextUtils._indexOf13062 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "indexOf", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)I");
			global::android.text.TextUtils._indexOf13063 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "indexOf", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;I)I");
			global::android.text.TextUtils._indexOf13064 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "indexOf", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;II)I");
			global::android.text.TextUtils._isEmpty13065 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "isEmpty", "(Ljava/lang/CharSequence;)Z");
			global::android.text.TextUtils._getChars13066 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "getChars", "(Ljava/lang/CharSequence;II[CI)V");
			global::android.text.TextUtils._regionMatches13067 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "regionMatches", "(Ljava/lang/CharSequence;ILjava/lang/CharSequence;II)Z");
			global::android.text.TextUtils._lastIndexOf13068 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "lastIndexOf", "(Ljava/lang/CharSequence;CI)I");
			global::android.text.TextUtils._lastIndexOf13069 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "lastIndexOf", "(Ljava/lang/CharSequence;CII)I");
			global::android.text.TextUtils._lastIndexOf13070 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "lastIndexOf", "(Ljava/lang/CharSequence;C)I");
			global::android.text.TextUtils._substring13071 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "substring", "(Ljava/lang/CharSequence;II)Ljava/lang/String;");
			global::android.text.TextUtils._concat13072 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "concat", "([Ljava/lang/CharSequence;)Ljava/lang/CharSequence;");
			global::android.text.TextUtils._replace13073 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "replace", "(Ljava/lang/CharSequence;[Ljava/lang/String;[Ljava/lang/CharSequence;)Ljava/lang/CharSequence;");
			global::android.text.TextUtils._split13074 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "split", "(Ljava/lang/String;Ljava/lang/String;)[Ljava/lang/String;");
			global::android.text.TextUtils._split13075 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "split", "(Ljava/lang/String;Ljava/util/regex/Pattern;)[Ljava/lang/String;");
			global::android.text.TextUtils._join13076 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "join", "(Ljava/lang/CharSequence;[Ljava/lang/Object;)Ljava/lang/String;");
			global::android.text.TextUtils._join13077 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "join", "(Ljava/lang/CharSequence;Ljava/lang/Iterable;)Ljava/lang/String;");
			global::android.text.TextUtils._ellipsize13078 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "ellipsize", "(Ljava/lang/CharSequence;Landroid/text/TextPaint;FLandroid/text/TextUtils$TruncateAt;)Ljava/lang/CharSequence;");
			global::android.text.TextUtils._ellipsize13079 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "ellipsize", "(Ljava/lang/CharSequence;Landroid/text/TextPaint;FLandroid/text/TextUtils$TruncateAt;ZLandroid/text/TextUtils$EllipsizeCallback;)Ljava/lang/CharSequence;");
			global::android.text.TextUtils._writeToParcel13080 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "writeToParcel", "(Ljava/lang/CharSequence;Landroid/os/Parcel;I)V");
			global::android.text.TextUtils._stringOrSpannedString13081 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "stringOrSpannedString", "(Ljava/lang/CharSequence;)Ljava/lang/CharSequence;");
			global::android.text.TextUtils._getTrimmedLength13082 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "getTrimmedLength", "(Ljava/lang/CharSequence;)I");
			global::android.text.TextUtils._getReverse13083 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "getReverse", "(Ljava/lang/CharSequence;II)Ljava/lang/CharSequence;");
			global::android.text.TextUtils._dumpSpans13084 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "dumpSpans", "(Ljava/lang/CharSequence;Landroid/util/Printer;Ljava/lang/String;)V");
			global::android.text.TextUtils._expandTemplate13085 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "expandTemplate", "(Ljava/lang/CharSequence;[Ljava/lang/CharSequence;)Ljava/lang/CharSequence;");
			global::android.text.TextUtils._getOffsetBefore13086 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "getOffsetBefore", "(Ljava/lang/CharSequence;I)I");
			global::android.text.TextUtils._getOffsetAfter13087 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "getOffsetAfter", "(Ljava/lang/CharSequence;I)I");
			global::android.text.TextUtils._copySpansFrom13088 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "copySpansFrom", "(Landroid/text/Spanned;IILjava/lang/Class;Landroid/text/Spannable;I)V");
			global::android.text.TextUtils._commaEllipsize13089 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "commaEllipsize", "(Ljava/lang/CharSequence;Landroid/text/TextPaint;FLjava/lang/String;Ljava/lang/String;)Ljava/lang/CharSequence;");
			global::android.text.TextUtils._htmlEncode13090 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "htmlEncode", "(Ljava/lang/String;)Ljava/lang/String;");
			global::android.text.TextUtils._isGraphic13091 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "isGraphic", "(Ljava/lang/CharSequence;)Z");
			global::android.text.TextUtils._isGraphic13092 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "isGraphic", "(C)Z");
			global::android.text.TextUtils._isDigitsOnly13093 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "isDigitsOnly", "(Ljava/lang/CharSequence;)Z");
			global::android.text.TextUtils._getCapsMode13094 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "getCapsMode", "(Ljava/lang/CharSequence;II)I");
			global::android.text.TextUtils._CHAR_SEQUENCE_CREATOR13095 = @__env.GetStaticFieldIDNoThrow(global::android.text.TextUtils.staticClass, "CHAR_SEQUENCE_CREATOR", "Landroid/os/Parcelable$Creator;");
		}
	}
}
