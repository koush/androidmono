namespace android.text.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Linkify : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Linkify(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.text.util.Linkify.MatchFilter_))]
		public partial interface MatchFilter  : global::MonoJavaBridge.IJavaObject 
		{
			bool acceptMatch(java.lang.CharSequence arg0, int arg1, int arg2);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.text.util.Linkify.MatchFilter))]
		internal sealed partial class MatchFilter_ : java.lang.Object, MatchFilter
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal MatchFilter_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			bool android.text.util.Linkify.MatchFilter.acceptMatch(java.lang.CharSequence arg0, int arg1, int arg2)
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.text.util.Linkify.MatchFilter_.staticClass, "acceptMatch", "(Ljava/lang/CharSequence;II)Z", ref global::android.text.util.Linkify.MatchFilter_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			static MatchFilter_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.text.util.Linkify.MatchFilter_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/util/Linkify$MatchFilter"));
			}
			internal static void InitJNI()
			{
			}
		}

		public delegate bool MatchFilterDelegate(java.lang.CharSequence arg0, int arg1, int arg2);

		internal partial class MatchFilterDelegateWrapper : java.lang.Object, MatchFilter
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected MatchFilterDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public MatchFilterDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.text.util.Linkify.MatchFilterDelegateWrapper._m0.native == global::System.IntPtr.Zero)
					global::android.text.util.Linkify.MatchFilterDelegateWrapper._m0 = @__env.GetMethodIDNoThrow(global::android.text.util.Linkify.MatchFilterDelegateWrapper.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.util.Linkify.MatchFilterDelegateWrapper.staticClass, global::android.text.util.Linkify.MatchFilterDelegateWrapper._m0);
				Init(@__env, handle);
			}
			static MatchFilterDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.text.util.Linkify.MatchFilterDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/util/Linkify_MatchFilterDelegateWrapper"));
			}
			internal static void InitJNI()
			{
			}
		}
		internal partial class MatchFilterDelegateWrapper
		{
			private MatchFilterDelegate myDelegate;
			public bool acceptMatch(java.lang.CharSequence arg0, int arg1, int arg2)
			{
				return myDelegate(arg0, arg1, arg2);
			}
			public static implicit operator MatchFilterDelegateWrapper(MatchFilterDelegate d)
			{
				global::android.text.util.Linkify.MatchFilterDelegateWrapper ret = new global::android.text.util.Linkify.MatchFilterDelegateWrapper();
				ret.myDelegate = d;
				global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
				return ret;
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.text.util.Linkify.TransformFilter_))]
		public partial interface TransformFilter  : global::MonoJavaBridge.IJavaObject 
		{
			global::java.lang.String transformUrl(java.util.regex.Matcher arg0, java.lang.String arg1);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.text.util.Linkify.TransformFilter))]
		internal sealed partial class TransformFilter_ : java.lang.Object, TransformFilter
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal TransformFilter_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			global::java.lang.String android.text.util.Linkify.TransformFilter.transformUrl(java.util.regex.Matcher arg0, java.lang.String arg1)
			{
				return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.text.util.Linkify.TransformFilter_.staticClass, "transformUrl", "(Ljava/util/regex/Matcher;Ljava/lang/String;)Ljava/lang/String;", ref global::android.text.util.Linkify.TransformFilter_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.String;
			}
			static TransformFilter_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.text.util.Linkify.TransformFilter_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/util/Linkify$TransformFilter"));
			}
			internal static void InitJNI()
			{
			}
		}

		public delegate java.lang.String TransformFilterDelegate(java.util.regex.Matcher arg0, java.lang.String arg1);

		internal partial class TransformFilterDelegateWrapper : java.lang.Object, TransformFilter
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected TransformFilterDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public TransformFilterDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.text.util.Linkify.TransformFilterDelegateWrapper._m0.native == global::System.IntPtr.Zero)
					global::android.text.util.Linkify.TransformFilterDelegateWrapper._m0 = @__env.GetMethodIDNoThrow(global::android.text.util.Linkify.TransformFilterDelegateWrapper.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.util.Linkify.TransformFilterDelegateWrapper.staticClass, global::android.text.util.Linkify.TransformFilterDelegateWrapper._m0);
				Init(@__env, handle);
			}
			static TransformFilterDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.text.util.Linkify.TransformFilterDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/util/Linkify_TransformFilterDelegateWrapper"));
			}
			internal static void InitJNI()
			{
			}
		}
		internal partial class TransformFilterDelegateWrapper
		{
			private TransformFilterDelegate myDelegate;
			public java.lang.String transformUrl(java.util.regex.Matcher arg0, java.lang.String arg1)
			{
				return myDelegate(arg0, arg1);
			}
			public static implicit operator TransformFilterDelegateWrapper(TransformFilterDelegate d)
			{
				global::android.text.util.Linkify.TransformFilterDelegateWrapper ret = new global::android.text.util.Linkify.TransformFilterDelegateWrapper();
				ret.myDelegate = d;
				global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
				return ret;
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static bool addLinks(android.widget.TextView arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.util.Linkify._m0.native == global::System.IntPtr.Zero)
				global::android.text.util.Linkify._m0 = @__env.GetStaticMethodIDNoThrow(global::android.text.util.Linkify.staticClass, "addLinks", "(Landroid/widget/TextView;I)Z");
			return @__env.CallStaticBooleanMethod(android.text.util.Linkify.staticClass, global::android.text.util.Linkify._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static void addLinks(android.widget.TextView arg0, java.util.regex.Pattern arg1, java.lang.String arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.util.Linkify._m1.native == global::System.IntPtr.Zero)
				global::android.text.util.Linkify._m1 = @__env.GetStaticMethodIDNoThrow(global::android.text.util.Linkify.staticClass, "addLinks", "(Landroid/widget/TextView;Ljava/util/regex/Pattern;Ljava/lang/String;)V");
			@__env.CallStaticVoidMethod(android.text.util.Linkify.staticClass, global::android.text.util.Linkify._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public static void addLinks(android.widget.TextView arg0, java.util.regex.Pattern arg1, java.lang.String arg2, android.text.util.Linkify.MatchFilter arg3, android.text.util.Linkify.TransformFilter arg4)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.util.Linkify._m2.native == global::System.IntPtr.Zero)
				global::android.text.util.Linkify._m2 = @__env.GetStaticMethodIDNoThrow(global::android.text.util.Linkify.staticClass, "addLinks", "(Landroid/widget/TextView;Ljava/util/regex/Pattern;Ljava/lang/String;Landroid/text/util/Linkify$MatchFilter;Landroid/text/util/Linkify$TransformFilter;)V");
			@__env.CallStaticVoidMethod(android.text.util.Linkify.staticClass, global::android.text.util.Linkify._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		public static void addLinks(android.widget.TextView arg0, java.util.regex.Pattern arg1, java.lang.String arg2, global::android.text.util.Linkify.MatchFilterDelegate arg3, global::android.text.util.Linkify.TransformFilterDelegate arg4)
		{
			addLinks(arg0, arg1, arg2, (global::android.text.util.Linkify.MatchFilterDelegateWrapper)arg3, (global::android.text.util.Linkify.TransformFilterDelegateWrapper)arg4);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public static bool addLinks(android.text.Spannable arg0, java.util.regex.Pattern arg1, java.lang.String arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.util.Linkify._m3.native == global::System.IntPtr.Zero)
				global::android.text.util.Linkify._m3 = @__env.GetStaticMethodIDNoThrow(global::android.text.util.Linkify.staticClass, "addLinks", "(Landroid/text/Spannable;Ljava/util/regex/Pattern;Ljava/lang/String;)Z");
			return @__env.CallStaticBooleanMethod(android.text.util.Linkify.staticClass, global::android.text.util.Linkify._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public static bool addLinks(android.text.Spannable arg0, java.util.regex.Pattern arg1, java.lang.String arg2, android.text.util.Linkify.MatchFilter arg3, android.text.util.Linkify.TransformFilter arg4)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.util.Linkify._m4.native == global::System.IntPtr.Zero)
				global::android.text.util.Linkify._m4 = @__env.GetStaticMethodIDNoThrow(global::android.text.util.Linkify.staticClass, "addLinks", "(Landroid/text/Spannable;Ljava/util/regex/Pattern;Ljava/lang/String;Landroid/text/util/Linkify$MatchFilter;Landroid/text/util/Linkify$TransformFilter;)Z");
			return @__env.CallStaticBooleanMethod(android.text.util.Linkify.staticClass, global::android.text.util.Linkify._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		public static bool addLinks(android.text.Spannable arg0, java.util.regex.Pattern arg1, java.lang.String arg2, global::android.text.util.Linkify.MatchFilterDelegate arg3, global::android.text.util.Linkify.TransformFilterDelegate arg4)
		{
			return addLinks(arg0, arg1, arg2, (global::android.text.util.Linkify.MatchFilterDelegateWrapper)arg3, (global::android.text.util.Linkify.TransformFilterDelegateWrapper)arg4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public static bool addLinks(android.text.Spannable arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.util.Linkify._m5.native == global::System.IntPtr.Zero)
				global::android.text.util.Linkify._m5 = @__env.GetStaticMethodIDNoThrow(global::android.text.util.Linkify.staticClass, "addLinks", "(Landroid/text/Spannable;I)Z");
			return @__env.CallStaticBooleanMethod(android.text.util.Linkify.staticClass, global::android.text.util.Linkify._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public Linkify() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.util.Linkify._m6.native == global::System.IntPtr.Zero)
				global::android.text.util.Linkify._m6 = @__env.GetMethodIDNoThrow(global::android.text.util.Linkify.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.util.Linkify.staticClass, global::android.text.util.Linkify._m6);
			Init(@__env, handle);
		}
		public static int WEB_URLS
		{
			get
			{
				return 1;
			}
		}
		public static int EMAIL_ADDRESSES
		{
			get
			{
				return 2;
			}
		}
		public static int PHONE_NUMBERS
		{
			get
			{
				return 4;
			}
		}
		public static int MAP_ADDRESSES
		{
			get
			{
				return 8;
			}
		}
		public static int ALL
		{
			get
			{
				return 15;
			}
		}
		internal static global::MonoJavaBridge.FieldId _sUrlMatchFilter5367;
		public static global::android.text.util.Linkify.MatchFilter sUrlMatchFilter
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.util.Linkify.MatchFilter>(@__env.GetStaticObjectField(global::android.text.util.Linkify.staticClass, _sUrlMatchFilter5367)) as android.text.util.Linkify.MatchFilter;
			}
		}
		internal static global::MonoJavaBridge.FieldId _sPhoneNumberMatchFilter5368;
		public static global::android.text.util.Linkify.MatchFilter sPhoneNumberMatchFilter
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.util.Linkify.MatchFilter>(@__env.GetStaticObjectField(global::android.text.util.Linkify.staticClass, _sPhoneNumberMatchFilter5368)) as android.text.util.Linkify.MatchFilter;
			}
		}
		internal static global::MonoJavaBridge.FieldId _sPhoneNumberTransformFilter5369;
		public static global::android.text.util.Linkify.TransformFilter sPhoneNumberTransformFilter
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.util.Linkify.TransformFilter>(@__env.GetStaticObjectField(global::android.text.util.Linkify.staticClass, _sPhoneNumberTransformFilter5369)) as android.text.util.Linkify.TransformFilter;
			}
		}
		static Linkify()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.util.Linkify.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/util/Linkify"));
			global::android.text.util.Linkify._sUrlMatchFilter5367 = @__env.GetStaticFieldIDNoThrow(global::android.text.util.Linkify.staticClass, "sUrlMatchFilter", "Landroid/text/util/Linkify$MatchFilter;");
			global::android.text.util.Linkify._sPhoneNumberMatchFilter5368 = @__env.GetStaticFieldIDNoThrow(global::android.text.util.Linkify.staticClass, "sPhoneNumberMatchFilter", "Landroid/text/util/Linkify$MatchFilter;");
			global::android.text.util.Linkify._sPhoneNumberTransformFilter5369 = @__env.GetStaticFieldIDNoThrow(global::android.text.util.Linkify.staticClass, "sPhoneNumberTransformFilter", "Landroid/text/util/Linkify$TransformFilter;");
		}
		internal static void InitJNI()
		{
		}
	}
}
