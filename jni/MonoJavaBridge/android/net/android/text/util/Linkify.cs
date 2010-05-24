namespace android.text.util 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class Linkify : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static Linkify() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.text.util.Linkify), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.text.util.Linkify(@__env); 
			} 
		} 
		protected Linkify(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface MatchFilter 
		{ 
			bool acceptMatch(java.lang.CharSequence arg0, int arg1, int arg2); 
		} 

		public partial class MatchFilter_ 
		{ 
			public static global::java.lang.Class _class 
			{ 
				get { return __MatchFilter.staticClass; } 
			} 
		} 

		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public sealed class __MatchFilter : java.lang.Object, MatchFilter
		{ 
			internal static global::java.lang.Class staticClass; 
			static __MatchFilter() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.text.util.Linkify.__MatchFilter), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.text.util.Linkify.__MatchFilter(@__env); 
				} 
			} 
			internal __MatchFilter(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _acceptMatch7473; 
			 bool android.text.util.Linkify.MatchFilter.acceptMatch(java.lang.CharSequence arg0, int arg1, int arg2) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.text.util.Linkify.__MatchFilter)) 
					return @__env.CallBooleanMethod(this, _acceptMatch7473, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
				else 
					return @__env.CallNonVirtualBooleanMethod(this, android.text.util.Linkify.__MatchFilter.staticClass, _acceptMatch7473, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.text.util.Linkify.__MatchFilter.staticClass = @__class; 
				global::android.text.util.Linkify.__MatchFilter._acceptMatch7473 = @__env.GetMethodID(global::android.text.util.Linkify.__MatchFilter.staticClass, "android.text.util.Linkify.MatchFilter.acceptMatch", "(Ljava/lang/CharSequence;II)Z"); 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface TransformFilter 
		{ 
			java.lang.String transformUrl(java.util.regex.Matcher arg0, java.lang.String arg1); 
		} 

		public partial class TransformFilter_ 
		{ 
			public static global::java.lang.Class _class 
			{ 
				get { return __TransformFilter.staticClass; } 
			} 
		} 

		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public sealed class __TransformFilter : java.lang.Object, TransformFilter
		{ 
			internal static global::java.lang.Class staticClass; 
			static __TransformFilter() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.text.util.Linkify.__TransformFilter), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.text.util.Linkify.__TransformFilter(@__env); 
				} 
			} 
			internal __TransformFilter(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _transformUrl7474; 
			 java.lang.String android.text.util.Linkify.TransformFilter.transformUrl(java.util.regex.Matcher arg0, java.lang.String arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.text.util.Linkify.__TransformFilter)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _transformUrl7474, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.text.util.Linkify.__TransformFilter.staticClass, _transformUrl7474, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.text.util.Linkify.__TransformFilter.staticClass = @__class; 
				global::android.text.util.Linkify.__TransformFilter._transformUrl7474 = @__env.GetMethodID(global::android.text.util.Linkify.__TransformFilter.staticClass, "android.text.util.Linkify.TransformFilter.transformUrl", "(Ljava/util/regex/Matcher;Ljava/lang/String;)Ljava/lang/String;"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addLinks7475; 
		public static bool addLinks(android.widget.TextView arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticBooleanMethod(android.text.util.Linkify.staticClass, _addLinks7475, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addLinks7476; 
		public static void addLinks(android.widget.TextView arg0, java.util.regex.Pattern arg1, java.lang.String arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.text.util.Linkify.staticClass, _addLinks7476, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addLinks7477; 
		public static void addLinks(android.widget.TextView arg0, java.util.regex.Pattern arg1, java.lang.String arg2, android.text.util.Linkify.MatchFilter arg3, android.text.util.Linkify.TransformFilter arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.text.util.Linkify.staticClass, _addLinks7477, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg3), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg4)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addLinks7478; 
		public static bool addLinks(android.text.Spannable arg0, java.util.regex.Pattern arg1, java.lang.String arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticBooleanMethod(android.text.util.Linkify.staticClass, _addLinks7478, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addLinks7479; 
		public static bool addLinks(android.text.Spannable arg0, java.util.regex.Pattern arg1, java.lang.String arg2, android.text.util.Linkify.MatchFilter arg3, android.text.util.Linkify.TransformFilter arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticBooleanMethod(android.text.util.Linkify.staticClass, _addLinks7479, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg3), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg4)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addLinks7480; 
		public static bool addLinks(android.text.Spannable arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticBooleanMethod(android.text.util.Linkify.staticClass, _addLinks7480, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Linkify7481; 
		public Linkify()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.text.util.Linkify.staticClass, _Linkify7481, this); 
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
		internal static global::net.sf.jni4net.jni.FieldId _sUrlMatchFilter7482; 
		public static android.text.util.Linkify.MatchFilter sUrlMatchFilter
		{ 
			get 
			{ 
				return default(android.text.util.Linkify.MatchFilter); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _sPhoneNumberMatchFilter7483; 
		public static android.text.util.Linkify.MatchFilter sPhoneNumberMatchFilter
		{ 
			get 
			{ 
				return default(android.text.util.Linkify.MatchFilter); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _sPhoneNumberTransformFilter7484; 
		public static android.text.util.Linkify.TransformFilter sPhoneNumberTransformFilter
		{ 
			get 
			{ 
				return default(android.text.util.Linkify.TransformFilter); 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.text.util.Linkify.staticClass = @__class; 
			global::android.text.util.Linkify._addLinks7475 = @__env.GetStaticMethodID(global::android.text.util.Linkify.staticClass, "addLinks", "(Landroid/widget/TextView;I)Z"); 
			global::android.text.util.Linkify._addLinks7476 = @__env.GetStaticMethodID(global::android.text.util.Linkify.staticClass, "addLinks", "(Landroid/widget/TextView;Ljava/util/regex/Pattern;Ljava/lang/String;)V"); 
			global::android.text.util.Linkify._addLinks7477 = @__env.GetStaticMethodID(global::android.text.util.Linkify.staticClass, "addLinks", "(Landroid/widget/TextView;Ljava/util/regex/Pattern;Ljava/lang/String;Landroid/text/util/Linkify$MatchFilter;Landroid/text/util/Linkify$TransformFilter;)V"); 
			global::android.text.util.Linkify._addLinks7478 = @__env.GetStaticMethodID(global::android.text.util.Linkify.staticClass, "addLinks", "(Landroid/text/Spannable;Ljava/util/regex/Pattern;Ljava/lang/String;)Z"); 
			global::android.text.util.Linkify._addLinks7479 = @__env.GetStaticMethodID(global::android.text.util.Linkify.staticClass, "addLinks", "(Landroid/text/Spannable;Ljava/util/regex/Pattern;Ljava/lang/String;Landroid/text/util/Linkify$MatchFilter;Landroid/text/util/Linkify$TransformFilter;)Z"); 
			global::android.text.util.Linkify._addLinks7480 = @__env.GetStaticMethodID(global::android.text.util.Linkify.staticClass, "addLinks", "(Landroid/text/Spannable;I)Z"); 
			global::android.text.util.Linkify._Linkify7481 = @__env.GetMethodID(global::android.text.util.Linkify.staticClass, "<init>", "()V"); 
		} 
	} 
} 
