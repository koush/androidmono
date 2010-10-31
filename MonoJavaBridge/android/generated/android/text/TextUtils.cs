namespace android.text
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class TextUtils : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
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
			internal EllipsizeCallback_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			void android.text.TextUtils.EllipsizeCallback.ellipsized(int arg0, int arg1)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.TextUtils.EllipsizeCallback_.staticClass, "ellipsized", "(II)V", ref global::android.text.TextUtils.EllipsizeCallback_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			static EllipsizeCallback_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.text.TextUtils.EllipsizeCallback_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/TextUtils$EllipsizeCallback"));
			}
		}

		public delegate void EllipsizeCallbackDelegate(int arg0, int arg1);

		internal partial class EllipsizeCallbackDelegateWrapper : java.lang.Object, EllipsizeCallback
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected EllipsizeCallbackDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public EllipsizeCallbackDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.text.TextUtils.EllipsizeCallbackDelegateWrapper._m0.native == global::System.IntPtr.Zero)
					global::android.text.TextUtils.EllipsizeCallbackDelegateWrapper._m0 = @__env.GetMethodIDNoThrow(global::android.text.TextUtils.EllipsizeCallbackDelegateWrapper.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.TextUtils.EllipsizeCallbackDelegateWrapper.staticClass, global::android.text.TextUtils.EllipsizeCallbackDelegateWrapper._m0);
				Init(@__env, handle);
			}
			static EllipsizeCallbackDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.text.TextUtils.EllipsizeCallbackDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/TextUtils_EllipsizeCallbackDelegateWrapper"));
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
			protected SimpleStringSplitter(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			public global::System.Collections.IEnumerator GetEnumerator()
			{
				return global::java.lang.IterableHelper.WrapIterator(iterator());
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public virtual global::java.util.Iterator iterator()
			{
				return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Iterator>(this, global::android.text.TextUtils.SimpleStringSplitter.staticClass, "iterator", "()Ljava/util/Iterator;", ref global::android.text.TextUtils.SimpleStringSplitter._m0) as java.util.Iterator;
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public virtual bool hasNext()
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.text.TextUtils.SimpleStringSplitter.staticClass, "hasNext", "()Z", ref global::android.text.TextUtils.SimpleStringSplitter._m1);
			}
			private static global::MonoJavaBridge.MethodId _m2;
			public virtual global::java.lang.Object next()
			{
				return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.text.TextUtils.SimpleStringSplitter.staticClass, "next", "()Ljava/lang/Object;", ref global::android.text.TextUtils.SimpleStringSplitter._m2) as java.lang.Object;
			}
			private static global::MonoJavaBridge.MethodId _m3;
			public virtual void remove()
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.TextUtils.SimpleStringSplitter.staticClass, "remove", "()V", ref global::android.text.TextUtils.SimpleStringSplitter._m3);
			}
			public new global::java.lang.String String
			{
				set
				{
					setString(value);
				}
			}
			private static global::MonoJavaBridge.MethodId _m4;
			public virtual void setString(java.lang.String arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.TextUtils.SimpleStringSplitter.staticClass, "setString", "(Ljava/lang/String;)V", ref global::android.text.TextUtils.SimpleStringSplitter._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static global::MonoJavaBridge.MethodId _m5;
			public SimpleStringSplitter(char arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.text.TextUtils.SimpleStringSplitter._m5.native == global::System.IntPtr.Zero)
					global::android.text.TextUtils.SimpleStringSplitter._m5 = @__env.GetMethodIDNoThrow(global::android.text.TextUtils.SimpleStringSplitter.staticClass, "<init>", "(C)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.TextUtils.SimpleStringSplitter.staticClass, global::android.text.TextUtils.SimpleStringSplitter._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			static SimpleStringSplitter()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.text.TextUtils.SimpleStringSplitter.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/TextUtils$SimpleStringSplitter"));
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
			internal StringSplitter_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			void android.text.TextUtils.StringSplitter.setString(java.lang.String arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.TextUtils.StringSplitter_.staticClass, "setString", "(Ljava/lang/String;)V", ref global::android.text.TextUtils.StringSplitter_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			public global::System.Collections.IEnumerator GetEnumerator()
			{
				return global::java.lang.IterableHelper.WrapIterator(((global::java.lang.Iterable)this).iterator());
			}
			private static global::MonoJavaBridge.MethodId _m1;
			global::java.util.Iterator java.lang.Iterable.iterator()
			{
				return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Iterator>(this, global::android.text.TextUtils.StringSplitter_.staticClass, "iterator", "()Ljava/util/Iterator;", ref global::android.text.TextUtils.StringSplitter_._m1) as java.util.Iterator;
			}
			static StringSplitter_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.text.TextUtils.StringSplitter_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/TextUtils$StringSplitter"));
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class TruncateAt : java.lang.Enum
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal TruncateAt(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public static global::android.text.TextUtils.TruncateAt[] values()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.text.TextUtils.TruncateAt._m0.native == global::System.IntPtr.Zero)
					global::android.text.TextUtils.TruncateAt._m0 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.TruncateAt.staticClass, "values", "()[Landroid/text/TextUtils/TruncateAt;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.text.TextUtils.TruncateAt>(@__env.CallStaticObjectMethod(android.text.TextUtils.TruncateAt.staticClass, global::android.text.TextUtils.TruncateAt._m0)) as android.text.TextUtils.TruncateAt[];
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public static global::android.text.TextUtils.TruncateAt valueOf(java.lang.String arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.text.TextUtils.TruncateAt._m1.native == global::System.IntPtr.Zero)
					global::android.text.TextUtils.TruncateAt._m1 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.TruncateAt.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/text/TextUtils$TruncateAt;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.text.TextUtils.TruncateAt>(@__env.CallStaticObjectMethod(android.text.TextUtils.TruncateAt.staticClass, global::android.text.TextUtils.TruncateAt._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.text.TextUtils.TruncateAt;
			}
			internal static global::MonoJavaBridge.FieldId _END5251;
			public static global::android.text.TextUtils.TruncateAt END
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.text.TextUtils.TruncateAt>(@__env.GetStaticObjectField(global::android.text.TextUtils.TruncateAt.staticClass, _END5251)) as android.text.TextUtils.TruncateAt;
				}
			}
			internal static global::MonoJavaBridge.FieldId _MARQUEE5252;
			public static global::android.text.TextUtils.TruncateAt MARQUEE
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.text.TextUtils.TruncateAt>(@__env.GetStaticObjectField(global::android.text.TextUtils.TruncateAt.staticClass, _MARQUEE5252)) as android.text.TextUtils.TruncateAt;
				}
			}
			internal static global::MonoJavaBridge.FieldId _MIDDLE5253;
			public static global::android.text.TextUtils.TruncateAt MIDDLE
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.text.TextUtils.TruncateAt>(@__env.GetStaticObjectField(global::android.text.TextUtils.TruncateAt.staticClass, _MIDDLE5253)) as android.text.TextUtils.TruncateAt;
				}
			}
			internal static global::MonoJavaBridge.FieldId _START5254;
			public static global::android.text.TextUtils.TruncateAt START
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.text.TextUtils.TruncateAt>(@__env.GetStaticObjectField(global::android.text.TextUtils.TruncateAt.staticClass, _START5254)) as android.text.TextUtils.TruncateAt;
				}
			}
			static TruncateAt()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.text.TextUtils.TruncateAt.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/TextUtils$TruncateAt"));
				global::android.text.TextUtils.TruncateAt._END5251 = @__env.GetStaticFieldIDNoThrow(global::android.text.TextUtils.TruncateAt.staticClass, "END", "Landroid/text/TextUtils$TruncateAt;");
				global::android.text.TextUtils.TruncateAt._MARQUEE5252 = @__env.GetStaticFieldIDNoThrow(global::android.text.TextUtils.TruncateAt.staticClass, "MARQUEE", "Landroid/text/TextUtils$TruncateAt;");
				global::android.text.TextUtils.TruncateAt._MIDDLE5253 = @__env.GetStaticFieldIDNoThrow(global::android.text.TextUtils.TruncateAt.staticClass, "MIDDLE", "Landroid/text/TextUtils$TruncateAt;");
				global::android.text.TextUtils.TruncateAt._START5254 = @__env.GetStaticFieldIDNoThrow(global::android.text.TextUtils.TruncateAt.staticClass, "START", "Landroid/text/TextUtils$TruncateAt;");
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static bool equals(java.lang.CharSequence arg0, java.lang.CharSequence arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.TextUtils._m0.native == global::System.IntPtr.Zero)
				global::android.text.TextUtils._m0 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "equals", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Z");
			return @__env.CallStaticBooleanMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public static bool equals(string arg0, string arg1)
		{
			return equals((global::java.lang.CharSequence)(global::java.lang.String)arg0, (global::java.lang.CharSequence)(global::java.lang.String)arg1);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static int indexOf(java.lang.CharSequence arg0, char arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.TextUtils._m1.native == global::System.IntPtr.Zero)
				global::android.text.TextUtils._m1 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "indexOf", "(Ljava/lang/CharSequence;CI)I");
			return @__env.CallStaticIntMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public static int indexOf(string arg0, char arg1, int arg2)
		{
			return indexOf((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public static int indexOf(java.lang.CharSequence arg0, char arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.TextUtils._m2.native == global::System.IntPtr.Zero)
				global::android.text.TextUtils._m2 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "indexOf", "(Ljava/lang/CharSequence;CII)I");
			return @__env.CallStaticIntMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		public static int indexOf(string arg0, char arg1, int arg2, int arg3)
		{
			return indexOf((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2, arg3);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public static int indexOf(java.lang.CharSequence arg0, char arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.TextUtils._m3.native == global::System.IntPtr.Zero)
				global::android.text.TextUtils._m3 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "indexOf", "(Ljava/lang/CharSequence;C)I");
			return @__env.CallStaticIntMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public static int indexOf(string arg0, char arg1)
		{
			return indexOf((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public static int indexOf(java.lang.CharSequence arg0, java.lang.CharSequence arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.TextUtils._m4.native == global::System.IntPtr.Zero)
				global::android.text.TextUtils._m4 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "indexOf", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)I");
			return @__env.CallStaticIntMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public static int indexOf(string arg0, string arg1)
		{
			return indexOf((global::java.lang.CharSequence)(global::java.lang.String)arg0, (global::java.lang.CharSequence)(global::java.lang.String)arg1);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public static int indexOf(java.lang.CharSequence arg0, java.lang.CharSequence arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.TextUtils._m5.native == global::System.IntPtr.Zero)
				global::android.text.TextUtils._m5 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "indexOf", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;I)I");
			return @__env.CallStaticIntMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public static int indexOf(string arg0, string arg1, int arg2)
		{
			return indexOf((global::java.lang.CharSequence)(global::java.lang.String)arg0, (global::java.lang.CharSequence)(global::java.lang.String)arg1, arg2);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public static int indexOf(java.lang.CharSequence arg0, java.lang.CharSequence arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.TextUtils._m6.native == global::System.IntPtr.Zero)
				global::android.text.TextUtils._m6 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "indexOf", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;II)I");
			return @__env.CallStaticIntMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		public static int indexOf(string arg0, string arg1, int arg2, int arg3)
		{
			return indexOf((global::java.lang.CharSequence)(global::java.lang.String)arg0, (global::java.lang.CharSequence)(global::java.lang.String)arg1, arg2, arg3);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public static bool isEmpty(java.lang.CharSequence arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.TextUtils._m7.native == global::System.IntPtr.Zero)
				global::android.text.TextUtils._m7 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "isEmpty", "(Ljava/lang/CharSequence;)Z");
			return @__env.CallStaticBooleanMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public static bool isEmpty(string arg0)
		{
			return isEmpty((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public static void getChars(java.lang.CharSequence arg0, int arg1, int arg2, char[] arg3, int arg4)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.TextUtils._m8.native == global::System.IntPtr.Zero)
				global::android.text.TextUtils._m8 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "getChars", "(Ljava/lang/CharSequence;II[CI)V");
			@__env.CallStaticVoidMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		public static void getChars(string arg0, int arg1, int arg2, char[] arg3, int arg4)
		{
			getChars((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2, arg3, arg4);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public static bool regionMatches(java.lang.CharSequence arg0, int arg1, java.lang.CharSequence arg2, int arg3, int arg4)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.TextUtils._m9.native == global::System.IntPtr.Zero)
				global::android.text.TextUtils._m9 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "regionMatches", "(Ljava/lang/CharSequence;ILjava/lang/CharSequence;II)Z");
			return @__env.CallStaticBooleanMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		public static bool regionMatches(string arg0, int arg1, string arg2, int arg3, int arg4)
		{
			return regionMatches((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, (global::java.lang.CharSequence)(global::java.lang.String)arg2, arg3, arg4);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public static int lastIndexOf(java.lang.CharSequence arg0, char arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.TextUtils._m10.native == global::System.IntPtr.Zero)
				global::android.text.TextUtils._m10 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "lastIndexOf", "(Ljava/lang/CharSequence;CI)I");
			return @__env.CallStaticIntMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public static int lastIndexOf(string arg0, char arg1, int arg2)
		{
			return lastIndexOf((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public static int lastIndexOf(java.lang.CharSequence arg0, char arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.TextUtils._m11.native == global::System.IntPtr.Zero)
				global::android.text.TextUtils._m11 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "lastIndexOf", "(Ljava/lang/CharSequence;CII)I");
			return @__env.CallStaticIntMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		public static int lastIndexOf(string arg0, char arg1, int arg2, int arg3)
		{
			return lastIndexOf((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2, arg3);
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public static int lastIndexOf(java.lang.CharSequence arg0, char arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.TextUtils._m12.native == global::System.IntPtr.Zero)
				global::android.text.TextUtils._m12 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "lastIndexOf", "(Ljava/lang/CharSequence;C)I");
			return @__env.CallStaticIntMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public static int lastIndexOf(string arg0, char arg1)
		{
			return lastIndexOf((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public static global::java.lang.String substring(java.lang.CharSequence arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.TextUtils._m13.native == global::System.IntPtr.Zero)
				global::android.text.TextUtils._m13 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "substring", "(Ljava/lang/CharSequence;II)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.String;
		}
		public static java.lang.String substring(string arg0, int arg1, int arg2)
		{
			return substring((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2);
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public static global::java.lang.CharSequence concat(java.lang.CharSequence[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.TextUtils._m14.native == global::System.IntPtr.Zero)
				global::android.text.TextUtils._m14 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "concat", "([Ljava/lang/CharSequence;)Ljava/lang/CharSequence;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallStaticObjectMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence;
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public static global::java.lang.CharSequence replace(java.lang.CharSequence arg0, java.lang.String[] arg1, java.lang.CharSequence[] arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.TextUtils._m15.native == global::System.IntPtr.Zero)
				global::android.text.TextUtils._m15 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "replace", "(Ljava/lang/CharSequence;[Ljava/lang/String;[Ljava/lang/CharSequence;)Ljava/lang/CharSequence;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallStaticObjectMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.CharSequence;
		}
		public static java.lang.CharSequence replace(string arg0, java.lang.String[] arg1, java.lang.CharSequence[] arg2)
		{
			return replace((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2);
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public static global::java.lang.String[] split(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.TextUtils._m16.native == global::System.IntPtr.Zero)
				global::android.text.TextUtils._m16 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "split", "(Ljava/lang/String;Ljava/lang/String;)[Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallStaticObjectMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String[];
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public static global::java.lang.String[] split(java.lang.String arg0, java.util.regex.Pattern arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.TextUtils._m17.native == global::System.IntPtr.Zero)
				global::android.text.TextUtils._m17 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "split", "(Ljava/lang/String;Ljava/util/regex/Pattern;)[Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallStaticObjectMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String[];
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public static global::java.lang.String join(java.lang.CharSequence arg0, java.lang.Object[] arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.TextUtils._m18.native == global::System.IntPtr.Zero)
				global::android.text.TextUtils._m18 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "join", "(Ljava/lang/CharSequence;[Ljava/lang/Object;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		public static java.lang.String join(string arg0, java.lang.Object[] arg1)
		{
			return join((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public static global::java.lang.String join(java.lang.CharSequence arg0, java.lang.Iterable arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.TextUtils._m19.native == global::System.IntPtr.Zero)
				global::android.text.TextUtils._m19 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "join", "(Ljava/lang/CharSequence;Ljava/lang/Iterable;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		public static java.lang.String join(string arg0, java.lang.Iterable arg1)
		{
			return join((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public static global::java.lang.CharSequence ellipsize(java.lang.CharSequence arg0, android.text.TextPaint arg1, float arg2, android.text.TextUtils.TruncateAt arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.TextUtils._m20.native == global::System.IntPtr.Zero)
				global::android.text.TextUtils._m20 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "ellipsize", "(Ljava/lang/CharSequence;Landroid/text/TextPaint;FLandroid/text/TextUtils$TruncateAt;)Ljava/lang/CharSequence;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallStaticObjectMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.lang.CharSequence;
		}
		public static java.lang.CharSequence ellipsize(string arg0, android.text.TextPaint arg1, float arg2, android.text.TextUtils.TruncateAt arg3)
		{
			return ellipsize((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2, arg3);
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public static global::java.lang.CharSequence ellipsize(java.lang.CharSequence arg0, android.text.TextPaint arg1, float arg2, android.text.TextUtils.TruncateAt arg3, bool arg4, android.text.TextUtils.EllipsizeCallback arg5)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.TextUtils._m21.native == global::System.IntPtr.Zero)
				global::android.text.TextUtils._m21 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "ellipsize", "(Ljava/lang/CharSequence;Landroid/text/TextPaint;FLandroid/text/TextUtils$TruncateAt;ZLandroid/text/TextUtils$EllipsizeCallback;)Ljava/lang/CharSequence;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallStaticObjectMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5))) as java.lang.CharSequence;
		}
		public static java.lang.CharSequence ellipsize(string arg0, android.text.TextPaint arg1, float arg2, android.text.TextUtils.TruncateAt arg3, bool arg4, global::android.text.TextUtils.EllipsizeCallbackDelegate arg5)
		{
			return ellipsize((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2, arg3, arg4, (global::android.text.TextUtils.EllipsizeCallbackDelegateWrapper)arg5);
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public static void writeToParcel(java.lang.CharSequence arg0, android.os.Parcel arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.TextUtils._m22.native == global::System.IntPtr.Zero)
				global::android.text.TextUtils._m22 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "writeToParcel", "(Ljava/lang/CharSequence;Landroid/os/Parcel;I)V");
			@__env.CallStaticVoidMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public static void writeToParcel(string arg0, android.os.Parcel arg1, int arg2)
		{
			writeToParcel((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2);
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public static global::java.lang.CharSequence stringOrSpannedString(java.lang.CharSequence arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.TextUtils._m23.native == global::System.IntPtr.Zero)
				global::android.text.TextUtils._m23 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "stringOrSpannedString", "(Ljava/lang/CharSequence;)Ljava/lang/CharSequence;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallStaticObjectMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._m23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence;
		}
		public static java.lang.CharSequence stringOrSpannedString(string arg0)
		{
			return stringOrSpannedString((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public static int getTrimmedLength(java.lang.CharSequence arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.TextUtils._m24.native == global::System.IntPtr.Zero)
				global::android.text.TextUtils._m24 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "getTrimmedLength", "(Ljava/lang/CharSequence;)I");
			return @__env.CallStaticIntMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._m24, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public static int getTrimmedLength(string arg0)
		{
			return getTrimmedLength((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public static global::java.lang.CharSequence getReverse(java.lang.CharSequence arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.TextUtils._m25.native == global::System.IntPtr.Zero)
				global::android.text.TextUtils._m25 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "getReverse", "(Ljava/lang/CharSequence;II)Ljava/lang/CharSequence;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallStaticObjectMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._m25, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.CharSequence;
		}
		public static java.lang.CharSequence getReverse(string arg0, int arg1, int arg2)
		{
			return getReverse((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2);
		}
		private static global::MonoJavaBridge.MethodId _m26;
		public static void dumpSpans(java.lang.CharSequence arg0, android.util.Printer arg1, java.lang.String arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.TextUtils._m26.native == global::System.IntPtr.Zero)
				global::android.text.TextUtils._m26 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "dumpSpans", "(Ljava/lang/CharSequence;Landroid/util/Printer;Ljava/lang/String;)V");
			@__env.CallStaticVoidMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._m26, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public static void dumpSpans(string arg0, global::android.util.PrinterDelegate arg1, java.lang.String arg2)
		{
			dumpSpans((global::java.lang.CharSequence)(global::java.lang.String)arg0, (global::android.util.PrinterDelegateWrapper)arg1, arg2);
		}
		private static global::MonoJavaBridge.MethodId _m27;
		public static global::java.lang.CharSequence expandTemplate(java.lang.CharSequence arg0, java.lang.CharSequence[] arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.TextUtils._m27.native == global::System.IntPtr.Zero)
				global::android.text.TextUtils._m27 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "expandTemplate", "(Ljava/lang/CharSequence;[Ljava/lang/CharSequence;)Ljava/lang/CharSequence;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallStaticObjectMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._m27, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.CharSequence;
		}
		public static java.lang.CharSequence expandTemplate(string arg0, java.lang.CharSequence[] arg1)
		{
			return expandTemplate((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
		}
		private static global::MonoJavaBridge.MethodId _m28;
		public static int getOffsetBefore(java.lang.CharSequence arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.TextUtils._m28.native == global::System.IntPtr.Zero)
				global::android.text.TextUtils._m28 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "getOffsetBefore", "(Ljava/lang/CharSequence;I)I");
			return @__env.CallStaticIntMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._m28, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public static int getOffsetBefore(string arg0, int arg1)
		{
			return getOffsetBefore((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
		}
		private static global::MonoJavaBridge.MethodId _m29;
		public static int getOffsetAfter(java.lang.CharSequence arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.TextUtils._m29.native == global::System.IntPtr.Zero)
				global::android.text.TextUtils._m29 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "getOffsetAfter", "(Ljava/lang/CharSequence;I)I");
			return @__env.CallStaticIntMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._m29, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public static int getOffsetAfter(string arg0, int arg1)
		{
			return getOffsetAfter((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
		}
		private static global::MonoJavaBridge.MethodId _m30;
		public static void copySpansFrom(android.text.Spanned arg0, int arg1, int arg2, java.lang.Class arg3, android.text.Spannable arg4, int arg5)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.TextUtils._m30.native == global::System.IntPtr.Zero)
				global::android.text.TextUtils._m30 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "copySpansFrom", "(Landroid/text/Spanned;IILjava/lang/Class;Landroid/text/Spannable;I)V");
			@__env.CallStaticVoidMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._m30, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		private static global::MonoJavaBridge.MethodId _m31;
		public static global::java.lang.CharSequence commaEllipsize(java.lang.CharSequence arg0, android.text.TextPaint arg1, float arg2, java.lang.String arg3, java.lang.String arg4)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.TextUtils._m31.native == global::System.IntPtr.Zero)
				global::android.text.TextUtils._m31 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "commaEllipsize", "(Ljava/lang/CharSequence;Landroid/text/TextPaint;FLjava/lang/String;Ljava/lang/String;)Ljava/lang/CharSequence;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallStaticObjectMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._m31, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as java.lang.CharSequence;
		}
		public static java.lang.CharSequence commaEllipsize(string arg0, android.text.TextPaint arg1, float arg2, java.lang.String arg3, java.lang.String arg4)
		{
			return commaEllipsize((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2, arg3, arg4);
		}
		private static global::MonoJavaBridge.MethodId _m32;
		public static global::java.lang.String htmlEncode(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.TextUtils._m32.native == global::System.IntPtr.Zero)
				global::android.text.TextUtils._m32 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "htmlEncode", "(Ljava/lang/String;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._m32, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m33;
		public static bool isGraphic(java.lang.CharSequence arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.TextUtils._m33.native == global::System.IntPtr.Zero)
				global::android.text.TextUtils._m33 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "isGraphic", "(Ljava/lang/CharSequence;)Z");
			return @__env.CallStaticBooleanMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._m33, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public static bool isGraphic(string arg0)
		{
			return isGraphic((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m34;
		public static bool isGraphic(char arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.TextUtils._m34.native == global::System.IntPtr.Zero)
				global::android.text.TextUtils._m34 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "isGraphic", "(C)Z");
			return @__env.CallStaticBooleanMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._m34, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m35;
		public static bool isDigitsOnly(java.lang.CharSequence arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.TextUtils._m35.native == global::System.IntPtr.Zero)
				global::android.text.TextUtils._m35 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "isDigitsOnly", "(Ljava/lang/CharSequence;)Z");
			return @__env.CallStaticBooleanMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._m35, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public static bool isDigitsOnly(string arg0)
		{
			return isDigitsOnly((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m36;
		public static int getCapsMode(java.lang.CharSequence arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.TextUtils._m36.native == global::System.IntPtr.Zero)
				global::android.text.TextUtils._m36 = @__env.GetStaticMethodIDNoThrow(global::android.text.TextUtils.staticClass, "getCapsMode", "(Ljava/lang/CharSequence;II)I");
			return @__env.CallStaticIntMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._m36, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public static int getCapsMode(string arg0, int arg1, int arg2)
		{
			return getCapsMode((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2);
		}
		internal static global::MonoJavaBridge.FieldId _CHAR_SEQUENCE_CREATOR5255;
		public static global::android.os.Parcelable_Creator CHAR_SEQUENCE_CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.text.TextUtils.staticClass, _CHAR_SEQUENCE_CREATOR5255)) as android.os.Parcelable_Creator;
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
		static TextUtils()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.TextUtils.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/TextUtils"));
			global::android.text.TextUtils._CHAR_SEQUENCE_CREATOR5255 = @__env.GetStaticFieldIDNoThrow(global::android.text.TextUtils.staticClass, "CHAR_SEQUENCE_CREATOR", "Landroid/os/Parcelable$Creator;");
		}
	}
}
