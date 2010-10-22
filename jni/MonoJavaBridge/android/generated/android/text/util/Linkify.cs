namespace android.text.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Linkify : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Linkify()
		{
			InitJNI();
		}
		protected Linkify(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.text.util.Linkify.MatchFilter_))]
		public interface MatchFilter  : global::MonoJavaBridge.IJavaObject 
		{
			bool acceptMatch(java.lang.CharSequence arg0, int arg1, int arg2);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.text.util.Linkify.MatchFilter))]
		public sealed partial class MatchFilter_ : java.lang.Object, MatchFilter
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static MatchFilter_()
			{
				InitJNI();
			}
			internal MatchFilter_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _acceptMatch13572;
			 bool android.text.util.Linkify.MatchFilter.acceptMatch(java.lang.CharSequence arg0, int arg1, int arg2) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.text.util.Linkify.MatchFilter_._acceptMatch13572, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.text.util.Linkify.MatchFilter_.staticClass, global::android.text.util.Linkify.MatchFilter_._acceptMatch13572, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.text.util.Linkify.MatchFilter_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/util/Linkify$MatchFilter"));
				global::android.text.util.Linkify.MatchFilter_._acceptMatch13572 = @__env.GetMethodIDNoThrow(global::android.text.util.Linkify.MatchFilter_.staticClass, "acceptMatch", "(Ljava/lang/CharSequence;II)Z");
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.text.util.Linkify.TransformFilter_))]
		public interface TransformFilter  : global::MonoJavaBridge.IJavaObject 
		{
			global::java.lang.String transformUrl(java.util.regex.Matcher arg0, java.lang.String arg1);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.text.util.Linkify.TransformFilter))]
		public sealed partial class TransformFilter_ : java.lang.Object, TransformFilter
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static TransformFilter_()
			{
				InitJNI();
			}
			internal TransformFilter_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _transformUrl13573;
			 global::java.lang.String android.text.util.Linkify.TransformFilter.transformUrl(java.util.regex.Matcher arg0, java.lang.String arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.util.Linkify.TransformFilter_._transformUrl13573, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.util.Linkify.TransformFilter_.staticClass, global::android.text.util.Linkify.TransformFilter_._transformUrl13573, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.text.util.Linkify.TransformFilter_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/util/Linkify$TransformFilter"));
				global::android.text.util.Linkify.TransformFilter_._transformUrl13573 = @__env.GetMethodIDNoThrow(global::android.text.util.Linkify.TransformFilter_.staticClass, "transformUrl", "(Ljava/util/regex/Matcher;Ljava/lang/String;)Ljava/lang/String;");
			}
		}
		internal static global::MonoJavaBridge.MethodId _addLinks13574;
		public static bool addLinks(android.widget.TextView arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.text.util.Linkify.staticClass, global::android.text.util.Linkify._addLinks13574, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addLinks13575;
		public static void addLinks(android.widget.TextView arg0, java.util.regex.Pattern arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.text.util.Linkify.staticClass, global::android.text.util.Linkify._addLinks13575, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _addLinks13576;
		public static void addLinks(android.widget.TextView arg0, java.util.regex.Pattern arg1, java.lang.String arg2, android.text.util.Linkify.MatchFilter arg3, android.text.util.Linkify.TransformFilter arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.text.util.Linkify.staticClass, global::android.text.util.Linkify._addLinks13576, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _addLinks13577;
		public static bool addLinks(android.text.Spannable arg0, java.util.regex.Pattern arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.text.util.Linkify.staticClass, global::android.text.util.Linkify._addLinks13577, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _addLinks13578;
		public static bool addLinks(android.text.Spannable arg0, java.util.regex.Pattern arg1, java.lang.String arg2, android.text.util.Linkify.MatchFilter arg3, android.text.util.Linkify.TransformFilter arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.text.util.Linkify.staticClass, global::android.text.util.Linkify._addLinks13578, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _addLinks13579;
		public static bool addLinks(android.text.Spannable arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.text.util.Linkify.staticClass, global::android.text.util.Linkify._addLinks13579, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _Linkify13580;
		public Linkify()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.util.Linkify.staticClass, global::android.text.util.Linkify._Linkify13580);
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
		internal static global::MonoJavaBridge.FieldId _sUrlMatchFilter13586;
		public static global::android.text.util.Linkify.MatchFilter sUrlMatchFilter
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.util.Linkify.MatchFilter>(@__env.GetStaticObjectField(global::android.text.util.Linkify.staticClass, _sUrlMatchFilter13586)) as android.text.util.Linkify.MatchFilter;
			}
		}
		internal static global::MonoJavaBridge.FieldId _sPhoneNumberMatchFilter13587;
		public static global::android.text.util.Linkify.MatchFilter sPhoneNumberMatchFilter
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.util.Linkify.MatchFilter>(@__env.GetStaticObjectField(global::android.text.util.Linkify.staticClass, _sPhoneNumberMatchFilter13587)) as android.text.util.Linkify.MatchFilter;
			}
		}
		internal static global::MonoJavaBridge.FieldId _sPhoneNumberTransformFilter13588;
		public static global::android.text.util.Linkify.TransformFilter sPhoneNumberTransformFilter
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.util.Linkify.TransformFilter>(@__env.GetStaticObjectField(global::android.text.util.Linkify.staticClass, _sPhoneNumberTransformFilter13588)) as android.text.util.Linkify.TransformFilter;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.util.Linkify.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/util/Linkify"));
			global::android.text.util.Linkify._addLinks13574 = @__env.GetStaticMethodIDNoThrow(global::android.text.util.Linkify.staticClass, "addLinks", "(Landroid/widget/TextView;I)Z");
			global::android.text.util.Linkify._addLinks13575 = @__env.GetStaticMethodIDNoThrow(global::android.text.util.Linkify.staticClass, "addLinks", "(Landroid/widget/TextView;Ljava/util/regex/Pattern;Ljava/lang/String;)V");
			global::android.text.util.Linkify._addLinks13576 = @__env.GetStaticMethodIDNoThrow(global::android.text.util.Linkify.staticClass, "addLinks", "(Landroid/widget/TextView;Ljava/util/regex/Pattern;Ljava/lang/String;Landroid/text/util/Linkify$MatchFilter;Landroid/text/util/Linkify$TransformFilter;)V");
			global::android.text.util.Linkify._addLinks13577 = @__env.GetStaticMethodIDNoThrow(global::android.text.util.Linkify.staticClass, "addLinks", "(Landroid/text/Spannable;Ljava/util/regex/Pattern;Ljava/lang/String;)Z");
			global::android.text.util.Linkify._addLinks13578 = @__env.GetStaticMethodIDNoThrow(global::android.text.util.Linkify.staticClass, "addLinks", "(Landroid/text/Spannable;Ljava/util/regex/Pattern;Ljava/lang/String;Landroid/text/util/Linkify$MatchFilter;Landroid/text/util/Linkify$TransformFilter;)Z");
			global::android.text.util.Linkify._addLinks13579 = @__env.GetStaticMethodIDNoThrow(global::android.text.util.Linkify.staticClass, "addLinks", "(Landroid/text/Spannable;I)Z");
			global::android.text.util.Linkify._Linkify13580 = @__env.GetMethodIDNoThrow(global::android.text.util.Linkify.staticClass, "<init>", "()V");
			global::android.text.util.Linkify._sUrlMatchFilter13586 = @__env.GetStaticFieldIDNoThrow(global::android.text.util.Linkify.staticClass, "sUrlMatchFilter", "Landroid/text/util/Linkify$MatchFilter;");
			global::android.text.util.Linkify._sPhoneNumberMatchFilter13587 = @__env.GetStaticFieldIDNoThrow(global::android.text.util.Linkify.staticClass, "sPhoneNumberMatchFilter", "Landroid/text/util/Linkify$MatchFilter;");
			global::android.text.util.Linkify._sPhoneNumberTransformFilter13588 = @__env.GetStaticFieldIDNoThrow(global::android.text.util.Linkify.staticClass, "sPhoneNumberTransformFilter", "Landroid/text/util/Linkify$TransformFilter;");
		}
	}
}
