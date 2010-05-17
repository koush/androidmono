namespace android.text 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class TextUtils : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static TextUtils() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.text.TextUtils), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.text.TextUtils(@__env); 
			} 
		} 
		protected TextUtils(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface EllipsizeCallback 
		{ 
			void ellipsized(int arg0, int arg1); 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public class SimpleStringSplitter : java.lang.Object, StringSplitter, java.util.Iterator
		{ 
			internal static global::java.lang.Class staticClass; 
			static SimpleStringSplitter() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.text.TextUtils.SimpleStringSplitter), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.text.TextUtils.SimpleStringSplitter(@__env); 
				} 
			} 
			protected SimpleStringSplitter(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _iterator6632; 
			public virtual java.util.Iterator iterator() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.text.TextUtils.SimpleStringSplitter)) 
					return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Iterator>(@__env, @__env.CallObjectMethodPtr(this, _iterator6632)); 
				else 
					return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Iterator>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.text.TextUtils.SimpleStringSplitter.staticClass, _iterator6632)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _hasNext6633; 
			public virtual bool hasNext() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.text.TextUtils.SimpleStringSplitter)) 
					return @__env.CallBooleanMethod(this, _hasNext6633); 
				else 
					return @__env.CallNonVirtualBooleanMethod(this, android.text.TextUtils.SimpleStringSplitter.staticClass, _hasNext6633); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _next6634; 
			public virtual java.lang.Object next() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.text.TextUtils.SimpleStringSplitter)) 
					return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, _next6634)); 
				else 
					return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.text.TextUtils.SimpleStringSplitter.staticClass, _next6634)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _remove6635; 
			public virtual void remove() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.text.TextUtils.SimpleStringSplitter)) 
					@__env.CallVoidMethod(this, _remove6635); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.text.TextUtils.SimpleStringSplitter.staticClass, _remove6635); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _setString6636; 
			public virtual void setString(java.lang.String arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.text.TextUtils.SimpleStringSplitter)) 
					@__env.CallVoidMethod(this, _setString6636, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.text.TextUtils.SimpleStringSplitter.staticClass, _setString6636, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _SimpleStringSplitter6637; 
			public SimpleStringSplitter(char arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.text.TextUtils.SimpleStringSplitter.staticClass, _SimpleStringSplitter6637, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.text.TextUtils.SimpleStringSplitter.staticClass = @__class; 
				global::android.text.TextUtils.SimpleStringSplitter._iterator6632 = @__env.GetMethodID(global::android.text.TextUtils.SimpleStringSplitter.staticClass, "iterator", "()Ljava/util/Iterator;"); 
				global::android.text.TextUtils.SimpleStringSplitter._hasNext6633 = @__env.GetMethodID(global::android.text.TextUtils.SimpleStringSplitter.staticClass, "hasNext", "()Z"); 
				global::android.text.TextUtils.SimpleStringSplitter._next6634 = @__env.GetMethodID(global::android.text.TextUtils.SimpleStringSplitter.staticClass, "next", "()Ljava/lang/Object;"); 
				global::android.text.TextUtils.SimpleStringSplitter._remove6635 = @__env.GetMethodID(global::android.text.TextUtils.SimpleStringSplitter.staticClass, "remove", "()V"); 
				global::android.text.TextUtils.SimpleStringSplitter._setString6636 = @__env.GetMethodID(global::android.text.TextUtils.SimpleStringSplitter.staticClass, "setString", "(Ljava/lang/String;)V"); 
				global::android.text.TextUtils.SimpleStringSplitter._SimpleStringSplitter6637 = @__env.GetMethodID(global::android.text.TextUtils.SimpleStringSplitter.staticClass, "<init>", "(C)V"); 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface StringSplitter : java.lang.Iterable
		{ 
			void setString(java.lang.String arg0); 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public sealed class TruncateAt : java.lang.Enum
		{ 
			internal new static global::java.lang.Class staticClass; 
			static TruncateAt() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.text.TextUtils.TruncateAt), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.text.TextUtils.TruncateAt(@__env); 
				} 
			} 
			internal TruncateAt(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _valueOf6638; 
			public static android.text.TextUtils.TruncateAt valueOf(java.lang.String arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.text.TextUtils.TruncateAt>(@__env, @__env.CallStaticObjectMethodPtr(android.text.TextUtils.TruncateAt.staticClass, _valueOf6638, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _values6639; 
			public static android.text.TextUtils.TruncateAt[] values() 
			{ 
				return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.text.TextUtils.TruncateAt.staticClass, _values6639)); 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _END6640; 
			public static android.text.TextUtils.TruncateAt END
			{ 
				get 
				{ 
					return default(android.text.TextUtils.TruncateAt); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _MARQUEE6641; 
			public static android.text.TextUtils.TruncateAt MARQUEE
			{ 
				get 
				{ 
					return default(android.text.TextUtils.TruncateAt); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _MIDDLE6642; 
			public static android.text.TextUtils.TruncateAt MIDDLE
			{ 
				get 
				{ 
					return default(android.text.TextUtils.TruncateAt); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _START6643; 
			public static android.text.TextUtils.TruncateAt START
			{ 
				get 
				{ 
					return default(android.text.TextUtils.TruncateAt); 
				} 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.text.TextUtils.TruncateAt.staticClass = @__class; 
				global::android.text.TextUtils.TruncateAt._valueOf6638 = @__env.GetStaticMethodID(global::android.text.TextUtils.TruncateAt.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/text/TextUtils$TruncateAt;"); 
				global::android.text.TextUtils.TruncateAt._values6639 = @__env.GetStaticMethodID(global::android.text.TextUtils.TruncateAt.staticClass, "values", "()[Landroid/text/TextUtils/TruncateAt;"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _equals6644; 
		public static bool equals(java.lang.CharSequence arg0, java.lang.CharSequence arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticBooleanMethod(android.text.TextUtils.staticClass, _equals6644, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _indexOf6645; 
		public static int indexOf(java.lang.CharSequence arg0, char arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.text.TextUtils.staticClass, _indexOf6645, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _indexOf6646; 
		public static int indexOf(java.lang.CharSequence arg0, char arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.text.TextUtils.staticClass, _indexOf6646, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _indexOf6647; 
		public static int indexOf(java.lang.CharSequence arg0, char arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.text.TextUtils.staticClass, _indexOf6647, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _indexOf6648; 
		public static int indexOf(java.lang.CharSequence arg0, java.lang.CharSequence arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.text.TextUtils.staticClass, _indexOf6648, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _indexOf6649; 
		public static int indexOf(java.lang.CharSequence arg0, java.lang.CharSequence arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.text.TextUtils.staticClass, _indexOf6649, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _indexOf6650; 
		public static int indexOf(java.lang.CharSequence arg0, java.lang.CharSequence arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.text.TextUtils.staticClass, _indexOf6650, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isEmpty6651; 
		public static bool isEmpty(java.lang.CharSequence arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticBooleanMethod(android.text.TextUtils.staticClass, _isEmpty6651, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getChars6652; 
		public static void getChars(java.lang.CharSequence arg0, int arg1, int arg2, char[] arg3, int arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.text.TextUtils.staticClass, _getChars6652, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _regionMatches6653; 
		public static bool regionMatches(java.lang.CharSequence arg0, int arg1, java.lang.CharSequence arg2, int arg3, int arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticBooleanMethod(android.text.TextUtils.staticClass, _regionMatches6653, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _lastIndexOf6654; 
		public static int lastIndexOf(java.lang.CharSequence arg0, char arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.text.TextUtils.staticClass, _lastIndexOf6654, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _lastIndexOf6655; 
		public static int lastIndexOf(java.lang.CharSequence arg0, char arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.text.TextUtils.staticClass, _lastIndexOf6655, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _lastIndexOf6656; 
		public static int lastIndexOf(java.lang.CharSequence arg0, char arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.text.TextUtils.staticClass, _lastIndexOf6656, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _substring6657; 
		public static java.lang.String substring(java.lang.CharSequence arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.text.TextUtils.staticClass, _substring6657, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _concat6658; 
		public static java.lang.CharSequence concat(java.lang.CharSequence[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallStaticObjectMethodPtr(android.text.TextUtils.staticClass, _concat6658, global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.CharSequence[], java.lang.CharSequence>(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _replace6659; 
		public static java.lang.CharSequence replace(java.lang.CharSequence arg0, java.lang.String[] arg1, java.lang.CharSequence[] arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallStaticObjectMethodPtr(android.text.TextUtils.staticClass, _replace6659, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.CharSequence[], java.lang.CharSequence>(@__env, arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _split6660; 
		public static java.lang.String[] split(java.lang.String arg0, java.lang.String arg1) 
		{ 
			return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.text.TextUtils.staticClass, _split6660, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _split6661; 
		public static java.lang.String[] split(java.lang.String arg0, java.util.regex.Pattern arg1) 
		{ 
			return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.text.TextUtils.staticClass, _split6661, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _join6662; 
		public static java.lang.String join(java.lang.CharSequence arg0, java.lang.Object[] arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.text.TextUtils.staticClass, _join6662, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.Object[], java.lang.Object>(@__env, arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _join6663; 
		public static java.lang.String join(java.lang.CharSequence arg0, java.lang.Iterable arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.text.TextUtils.staticClass, _join6663, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ellipsize6664; 
		public static java.lang.CharSequence ellipsize(java.lang.CharSequence arg0, android.text.TextPaint arg1, float arg2, android.text.TextUtils.TruncateAt arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallStaticObjectMethodPtr(android.text.TextUtils.staticClass, _ellipsize6664, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ellipsize6665; 
		public static java.lang.CharSequence ellipsize(java.lang.CharSequence arg0, android.text.TextPaint arg1, float arg2, android.text.TextUtils.TruncateAt arg3, bool arg4, android.text.TextUtils.EllipsizeCallback arg5) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallStaticObjectMethodPtr(android.text.TextUtils.staticClass, _ellipsize6665, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg5))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel6666; 
		public static void writeToParcel(java.lang.CharSequence arg0, android.os.Parcel arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.text.TextUtils.staticClass, _writeToParcel6666, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _stringOrSpannedString6667; 
		public static java.lang.CharSequence stringOrSpannedString(java.lang.CharSequence arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallStaticObjectMethodPtr(android.text.TextUtils.staticClass, _stringOrSpannedString6667, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTrimmedLength6668; 
		public static int getTrimmedLength(java.lang.CharSequence arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.text.TextUtils.staticClass, _getTrimmedLength6668, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getReverse6669; 
		public static java.lang.CharSequence getReverse(java.lang.CharSequence arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallStaticObjectMethodPtr(android.text.TextUtils.staticClass, _getReverse6669, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dumpSpans6670; 
		public static void dumpSpans(java.lang.CharSequence arg0, android.util.Printer arg1, java.lang.String arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.text.TextUtils.staticClass, _dumpSpans6670, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _expandTemplate6671; 
		public static java.lang.CharSequence expandTemplate(java.lang.CharSequence arg0, java.lang.CharSequence[] arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallStaticObjectMethodPtr(android.text.TextUtils.staticClass, _expandTemplate6671, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.CharSequence[], java.lang.CharSequence>(@__env, arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getOffsetBefore6672; 
		public static int getOffsetBefore(java.lang.CharSequence arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.text.TextUtils.staticClass, _getOffsetBefore6672, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getOffsetAfter6673; 
		public static int getOffsetAfter(java.lang.CharSequence arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.text.TextUtils.staticClass, _getOffsetAfter6673, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _copySpansFrom6674; 
		public static void copySpansFrom(android.text.Spanned arg0, int arg1, int arg2, java.lang.Class arg3, android.text.Spannable arg4, int arg5) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.text.TextUtils.staticClass, _copySpansFrom6674, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _commaEllipsize6675; 
		public static java.lang.CharSequence commaEllipsize(java.lang.CharSequence arg0, android.text.TextPaint arg1, float arg2, java.lang.String arg3, java.lang.String arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallStaticObjectMethodPtr(android.text.TextUtils.staticClass, _commaEllipsize6675, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _htmlEncode6676; 
		public static java.lang.String htmlEncode(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.text.TextUtils.staticClass, _htmlEncode6676, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isGraphic6677; 
		public static bool isGraphic(java.lang.CharSequence arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticBooleanMethod(android.text.TextUtils.staticClass, _isGraphic6677, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isGraphic6678; 
		public static bool isGraphic(char arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticBooleanMethod(android.text.TextUtils.staticClass, _isGraphic6678, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isDigitsOnly6679; 
		public static bool isDigitsOnly(java.lang.CharSequence arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticBooleanMethod(android.text.TextUtils.staticClass, _isDigitsOnly6679, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCapsMode6680; 
		public static int getCapsMode(java.lang.CharSequence arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.text.TextUtils.staticClass, _getCapsMode6680, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _CHAR_SEQUENCE_CREATOR6681; 
		public static android.os.Parcelable_Creator CHAR_SEQUENCE_CREATOR
		{ 
			get 
			{ 
				return default(android.os.Parcelable_Creator); 
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
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.text.TextUtils.staticClass = @__class; 
			global::android.text.TextUtils._equals6644 = @__env.GetStaticMethodID(global::android.text.TextUtils.staticClass, "equals", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Z"); 
			global::android.text.TextUtils._indexOf6645 = @__env.GetStaticMethodID(global::android.text.TextUtils.staticClass, "indexOf", "(Ljava/lang/CharSequence;CI)I"); 
			global::android.text.TextUtils._indexOf6646 = @__env.GetStaticMethodID(global::android.text.TextUtils.staticClass, "indexOf", "(Ljava/lang/CharSequence;CII)I"); 
			global::android.text.TextUtils._indexOf6647 = @__env.GetStaticMethodID(global::android.text.TextUtils.staticClass, "indexOf", "(Ljava/lang/CharSequence;C)I"); 
			global::android.text.TextUtils._indexOf6648 = @__env.GetStaticMethodID(global::android.text.TextUtils.staticClass, "indexOf", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)I"); 
			global::android.text.TextUtils._indexOf6649 = @__env.GetStaticMethodID(global::android.text.TextUtils.staticClass, "indexOf", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;I)I"); 
			global::android.text.TextUtils._indexOf6650 = @__env.GetStaticMethodID(global::android.text.TextUtils.staticClass, "indexOf", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;II)I"); 
			global::android.text.TextUtils._isEmpty6651 = @__env.GetStaticMethodID(global::android.text.TextUtils.staticClass, "isEmpty", "(Ljava/lang/CharSequence;)Z"); 
			global::android.text.TextUtils._getChars6652 = @__env.GetStaticMethodID(global::android.text.TextUtils.staticClass, "getChars", "(Ljava/lang/CharSequence;II[CI)V"); 
			global::android.text.TextUtils._regionMatches6653 = @__env.GetStaticMethodID(global::android.text.TextUtils.staticClass, "regionMatches", "(Ljava/lang/CharSequence;ILjava/lang/CharSequence;II)Z"); 
			global::android.text.TextUtils._lastIndexOf6654 = @__env.GetStaticMethodID(global::android.text.TextUtils.staticClass, "lastIndexOf", "(Ljava/lang/CharSequence;CI)I"); 
			global::android.text.TextUtils._lastIndexOf6655 = @__env.GetStaticMethodID(global::android.text.TextUtils.staticClass, "lastIndexOf", "(Ljava/lang/CharSequence;CII)I"); 
			global::android.text.TextUtils._lastIndexOf6656 = @__env.GetStaticMethodID(global::android.text.TextUtils.staticClass, "lastIndexOf", "(Ljava/lang/CharSequence;C)I"); 
			global::android.text.TextUtils._substring6657 = @__env.GetStaticMethodID(global::android.text.TextUtils.staticClass, "substring", "(Ljava/lang/CharSequence;II)Ljava/lang/String;"); 
			global::android.text.TextUtils._concat6658 = @__env.GetStaticMethodID(global::android.text.TextUtils.staticClass, "concat", "([Ljava/lang/CharSequence;)Ljava/lang/CharSequence;"); 
			global::android.text.TextUtils._replace6659 = @__env.GetStaticMethodID(global::android.text.TextUtils.staticClass, "replace", "(Ljava/lang/CharSequence;[Ljava/lang/String;[Ljava/lang/CharSequence;)Ljava/lang/CharSequence;"); 
			global::android.text.TextUtils._split6660 = @__env.GetStaticMethodID(global::android.text.TextUtils.staticClass, "split", "(Ljava/lang/String;Ljava/lang/String;)[Ljava/lang/String;"); 
			global::android.text.TextUtils._split6661 = @__env.GetStaticMethodID(global::android.text.TextUtils.staticClass, "split", "(Ljava/lang/String;Ljava/util/regex/Pattern;)[Ljava/lang/String;"); 
			global::android.text.TextUtils._join6662 = @__env.GetStaticMethodID(global::android.text.TextUtils.staticClass, "join", "(Ljava/lang/CharSequence;[Ljava/lang/Object;)Ljava/lang/String;"); 
			global::android.text.TextUtils._join6663 = @__env.GetStaticMethodID(global::android.text.TextUtils.staticClass, "join", "(Ljava/lang/CharSequence;Ljava/lang/Iterable;)Ljava/lang/String;"); 
			global::android.text.TextUtils._ellipsize6664 = @__env.GetStaticMethodID(global::android.text.TextUtils.staticClass, "ellipsize", "(Ljava/lang/CharSequence;Landroid/text/TextPaint;FLandroid/text/TextUtils$TruncateAt;)Ljava/lang/CharSequence;"); 
			global::android.text.TextUtils._ellipsize6665 = @__env.GetStaticMethodID(global::android.text.TextUtils.staticClass, "ellipsize", "(Ljava/lang/CharSequence;Landroid/text/TextPaint;FLandroid/text/TextUtils$TruncateAt;ZLandroid/text/TextUtils$EllipsizeCallback;)Ljava/lang/CharSequence;"); 
			global::android.text.TextUtils._writeToParcel6666 = @__env.GetStaticMethodID(global::android.text.TextUtils.staticClass, "writeToParcel", "(Ljava/lang/CharSequence;Landroid/os/Parcel;I)V"); 
			global::android.text.TextUtils._stringOrSpannedString6667 = @__env.GetStaticMethodID(global::android.text.TextUtils.staticClass, "stringOrSpannedString", "(Ljava/lang/CharSequence;)Ljava/lang/CharSequence;"); 
			global::android.text.TextUtils._getTrimmedLength6668 = @__env.GetStaticMethodID(global::android.text.TextUtils.staticClass, "getTrimmedLength", "(Ljava/lang/CharSequence;)I"); 
			global::android.text.TextUtils._getReverse6669 = @__env.GetStaticMethodID(global::android.text.TextUtils.staticClass, "getReverse", "(Ljava/lang/CharSequence;II)Ljava/lang/CharSequence;"); 
			global::android.text.TextUtils._dumpSpans6670 = @__env.GetStaticMethodID(global::android.text.TextUtils.staticClass, "dumpSpans", "(Ljava/lang/CharSequence;Landroid/util/Printer;Ljava/lang/String;)V"); 
			global::android.text.TextUtils._expandTemplate6671 = @__env.GetStaticMethodID(global::android.text.TextUtils.staticClass, "expandTemplate", "(Ljava/lang/CharSequence;[Ljava/lang/CharSequence;)Ljava/lang/CharSequence;"); 
			global::android.text.TextUtils._getOffsetBefore6672 = @__env.GetStaticMethodID(global::android.text.TextUtils.staticClass, "getOffsetBefore", "(Ljava/lang/CharSequence;I)I"); 
			global::android.text.TextUtils._getOffsetAfter6673 = @__env.GetStaticMethodID(global::android.text.TextUtils.staticClass, "getOffsetAfter", "(Ljava/lang/CharSequence;I)I"); 
			global::android.text.TextUtils._copySpansFrom6674 = @__env.GetStaticMethodID(global::android.text.TextUtils.staticClass, "copySpansFrom", "(Landroid/text/Spanned;IILjava/lang/Class;Landroid/text/Spannable;I)V"); 
			global::android.text.TextUtils._commaEllipsize6675 = @__env.GetStaticMethodID(global::android.text.TextUtils.staticClass, "commaEllipsize", "(Ljava/lang/CharSequence;Landroid/text/TextPaint;FLjava/lang/String;Ljava/lang/String;)Ljava/lang/CharSequence;"); 
			global::android.text.TextUtils._htmlEncode6676 = @__env.GetStaticMethodID(global::android.text.TextUtils.staticClass, "htmlEncode", "(Ljava/lang/String;)Ljava/lang/String;"); 
			global::android.text.TextUtils._isGraphic6677 = @__env.GetStaticMethodID(global::android.text.TextUtils.staticClass, "isGraphic", "(Ljava/lang/CharSequence;)Z"); 
			global::android.text.TextUtils._isGraphic6678 = @__env.GetStaticMethodID(global::android.text.TextUtils.staticClass, "isGraphic", "(C)Z"); 
			global::android.text.TextUtils._isDigitsOnly6679 = @__env.GetStaticMethodID(global::android.text.TextUtils.staticClass, "isDigitsOnly", "(Ljava/lang/CharSequence;)Z"); 
			global::android.text.TextUtils._getCapsMode6680 = @__env.GetStaticMethodID(global::android.text.TextUtils.staticClass, "getCapsMode", "(Ljava/lang/CharSequence;II)I"); 
		} 
	} 
} 
