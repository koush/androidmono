namespace android.text
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class TextUtils : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static TextUtils()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.text.TextUtils), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
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

		public partial class EllipsizeCallback_
		{
			public static global::java.lang.Class _class
			{
				get { return __EllipsizeCallback.staticClass; }
			}
		}

		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public sealed class __EllipsizeCallback : java.lang.Object, EllipsizeCallback
		{
			internal static global::java.lang.Class staticClass;
			static __EllipsizeCallback()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.text.TextUtils.__EllipsizeCallback), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.text.TextUtils.__EllipsizeCallback(@__env);
				}
			}
			internal __EllipsizeCallback(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _ellipsized7607;
			 void android.text.TextUtils.EllipsizeCallback.ellipsized(int arg0, int arg1) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.text.TextUtils.__EllipsizeCallback._ellipsized7607, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.text.TextUtils.__EllipsizeCallback.staticClass, global::android.text.TextUtils.__EllipsizeCallback._ellipsized7607, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.text.TextUtils.__EllipsizeCallback.staticClass = @__class;
				global::android.text.TextUtils.__EllipsizeCallback._ellipsized7607 = @__env.GetMethodID(global::android.text.TextUtils.__EllipsizeCallback.staticClass, "android.text.TextUtils.EllipsizeCallback.ellipsized", "(II)V");
			}
		}
		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public class SimpleStringSplitter : java.lang.Object, StringSplitter, java.util.Iterator
		{
			internal static global::java.lang.Class staticClass;
			static SimpleStringSplitter()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.text.TextUtils.SimpleStringSplitter), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
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
			internal static global::net.sf.jni4net.jni.MethodId _iterator7608;
			public virtual global::java.util.Iterator iterator() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Iterator>(@__env, @__env.CallObjectMethodPtr(this, global::android.text.TextUtils.SimpleStringSplitter._iterator7608));
				else
					return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Iterator>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.text.TextUtils.SimpleStringSplitter.staticClass, global::android.text.TextUtils.SimpleStringSplitter._iterator7608));
			}
			internal static global::net.sf.jni4net.jni.MethodId _hasNext7609;
			public virtual bool hasNext() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this, global::android.text.TextUtils.SimpleStringSplitter._hasNext7609);
				else
					return @__env.CallNonVirtualBooleanMethod(this, global::android.text.TextUtils.SimpleStringSplitter.staticClass, global::android.text.TextUtils.SimpleStringSplitter._hasNext7609);
			}
			internal static global::net.sf.jni4net.jni.MethodId _next7610;
			public virtual global::java.lang.Object next() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::android.text.TextUtils.SimpleStringSplitter._next7610));
				else
					return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.text.TextUtils.SimpleStringSplitter.staticClass, global::android.text.TextUtils.SimpleStringSplitter._next7610));
			}
			internal static global::net.sf.jni4net.jni.MethodId _remove7611;
			public virtual void remove() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.text.TextUtils.SimpleStringSplitter._remove7611);
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.text.TextUtils.SimpleStringSplitter.staticClass, global::android.text.TextUtils.SimpleStringSplitter._remove7611);
			}
			internal static global::net.sf.jni4net.jni.MethodId _setString7612;
			public virtual void setString(java.lang.String arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.text.TextUtils.SimpleStringSplitter._setString7612, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.text.TextUtils.SimpleStringSplitter.staticClass, global::android.text.TextUtils.SimpleStringSplitter._setString7612, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _SimpleStringSplitter7613;
			public SimpleStringSplitter(char arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.text.TextUtils.SimpleStringSplitter.staticClass, global::android.text.TextUtils.SimpleStringSplitter._SimpleStringSplitter7613, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.text.TextUtils.SimpleStringSplitter.staticClass = @__class;
				global::android.text.TextUtils.SimpleStringSplitter._iterator7608 = @__env.GetMethodID(global::android.text.TextUtils.SimpleStringSplitter.staticClass, "iterator", "()Ljava/util/Iterator;");
				global::android.text.TextUtils.SimpleStringSplitter._hasNext7609 = @__env.GetMethodID(global::android.text.TextUtils.SimpleStringSplitter.staticClass, "hasNext", "()Z");
				global::android.text.TextUtils.SimpleStringSplitter._next7610 = @__env.GetMethodID(global::android.text.TextUtils.SimpleStringSplitter.staticClass, "next", "()Ljava/lang/Object;");
				global::android.text.TextUtils.SimpleStringSplitter._remove7611 = @__env.GetMethodID(global::android.text.TextUtils.SimpleStringSplitter.staticClass, "remove", "()V");
				global::android.text.TextUtils.SimpleStringSplitter._setString7612 = @__env.GetMethodID(global::android.text.TextUtils.SimpleStringSplitter.staticClass, "setString", "(Ljava/lang/String;)V");
				global::android.text.TextUtils.SimpleStringSplitter._SimpleStringSplitter7613 = @__env.GetMethodID(global::android.text.TextUtils.SimpleStringSplitter.staticClass, "<init>", "(C)V");
			}
		}
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
		public interface StringSplitter : java.lang.Iterable
		{
			void setString(java.lang.String arg0);
		}

		public partial class StringSplitter_
		{
			public static global::java.lang.Class _class
			{
				get { return __StringSplitter.staticClass; }
			}
		}

		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public sealed class __StringSplitter : java.lang.Object, StringSplitter
		{
			internal static global::java.lang.Class staticClass;
			static __StringSplitter()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.text.TextUtils.__StringSplitter), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.text.TextUtils.__StringSplitter(@__env);
				}
			}
			internal __StringSplitter(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _setString7614;
			 void android.text.TextUtils.StringSplitter.setString(java.lang.String arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.text.TextUtils.__StringSplitter._setString7614, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.text.TextUtils.__StringSplitter.staticClass, global::android.text.TextUtils.__StringSplitter._setString7614, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _iterator7615;
			 global::java.util.Iterator java.lang.Iterable.iterator() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Iterator>(@__env, @__env.CallObjectMethodPtr(this, global::android.text.TextUtils.__StringSplitter._iterator7615));
				else
					return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Iterator>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.text.TextUtils.__StringSplitter.staticClass, global::android.text.TextUtils.__StringSplitter._iterator7615));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.text.TextUtils.__StringSplitter.staticClass = @__class;
				global::android.text.TextUtils.__StringSplitter._setString7614 = @__env.GetMethodID(global::android.text.TextUtils.__StringSplitter.staticClass, "android.text.TextUtils.StringSplitter.setString", "(Ljava/lang/String;)V");
				global::android.text.TextUtils.__StringSplitter._iterator7615 = @__env.GetMethodID(global::android.text.TextUtils.__StringSplitter.staticClass, "java.lang.Iterable.iterator", "()Ljava/util/Iterator;");
			}
		}
		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public sealed class TruncateAt : java.lang.Enum
		{
			internal new static global::java.lang.Class staticClass;
			static TruncateAt()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.text.TextUtils.TruncateAt), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
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
			internal static global::net.sf.jni4net.jni.MethodId _values7616;
			public static global::android.text.TextUtils.TruncateAt[] values() 
			{
				return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.text.TextUtils.TruncateAt.staticClass, global::android.text.TextUtils.TruncateAt._values7616));
			}
			internal static global::net.sf.jni4net.jni.MethodId _valueOf7617;
			public static global::android.text.TextUtils.TruncateAt valueOf(java.lang.String arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.text.TextUtils.TruncateAt>(@__env, @__env.CallStaticObjectMethodPtr(android.text.TextUtils.TruncateAt.staticClass, global::android.text.TextUtils.TruncateAt._valueOf7617, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			}
			internal static global::net.sf.jni4net.jni.FieldId _END7618;
			public static global::android.text.TextUtils.TruncateAt END
			{
				get
				{
					return default(global::android.text.TextUtils.TruncateAt);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _MARQUEE7619;
			public static global::android.text.TextUtils.TruncateAt MARQUEE
			{
				get
				{
					return default(global::android.text.TextUtils.TruncateAt);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _MIDDLE7620;
			public static global::android.text.TextUtils.TruncateAt MIDDLE
			{
				get
				{
					return default(global::android.text.TextUtils.TruncateAt);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _START7621;
			public static global::android.text.TextUtils.TruncateAt START
			{
				get
				{
					return default(global::android.text.TextUtils.TruncateAt);
				}
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.text.TextUtils.TruncateAt.staticClass = @__class;
				global::android.text.TextUtils.TruncateAt._values7616 = @__env.GetStaticMethodID(global::android.text.TextUtils.TruncateAt.staticClass, "values", "()[Landroid/text/TextUtils/TruncateAt;");
				global::android.text.TextUtils.TruncateAt._valueOf7617 = @__env.GetStaticMethodID(global::android.text.TextUtils.TruncateAt.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/text/TextUtils$TruncateAt;");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _equals7622;
		public static bool equals(java.lang.CharSequence arg0, java.lang.CharSequence arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._equals7622, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _indexOf7623;
		public static int indexOf(java.lang.CharSequence arg0, char arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._indexOf7623, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _indexOf7624;
		public static int indexOf(java.lang.CharSequence arg0, char arg1, int arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._indexOf7624, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _indexOf7625;
		public static int indexOf(java.lang.CharSequence arg0, char arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._indexOf7625, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _indexOf7626;
		public static int indexOf(java.lang.CharSequence arg0, java.lang.CharSequence arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._indexOf7626, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _indexOf7627;
		public static int indexOf(java.lang.CharSequence arg0, java.lang.CharSequence arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._indexOf7627, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _indexOf7628;
		public static int indexOf(java.lang.CharSequence arg0, java.lang.CharSequence arg1, int arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._indexOf7628, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isEmpty7629;
		public static bool isEmpty(java.lang.CharSequence arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._isEmpty7629, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getChars7630;
		public static void getChars(java.lang.CharSequence arg0, int arg1, int arg2, char[] arg3, int arg4) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._getChars7630, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4));
		}
		internal static global::net.sf.jni4net.jni.MethodId _regionMatches7631;
		public static bool regionMatches(java.lang.CharSequence arg0, int arg1, java.lang.CharSequence arg2, int arg3, int arg4) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._regionMatches7631, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4));
		}
		internal static global::net.sf.jni4net.jni.MethodId _lastIndexOf7632;
		public static int lastIndexOf(java.lang.CharSequence arg0, char arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._lastIndexOf7632, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _lastIndexOf7633;
		public static int lastIndexOf(java.lang.CharSequence arg0, char arg1, int arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._lastIndexOf7633, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _lastIndexOf7634;
		public static int lastIndexOf(java.lang.CharSequence arg0, char arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._lastIndexOf7634, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _substring7635;
		public static global::java.lang.String substring(java.lang.CharSequence arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.text.TextUtils.staticClass, global::android.text.TextUtils._substring7635, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _concat7636;
		public static global::java.lang.CharSequence concat(java.lang.CharSequence[] arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallStaticObjectMethodPtr(android.text.TextUtils.staticClass, global::android.text.TextUtils._concat7636, global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.CharSequence[], java.lang.CharSequence>(@__env, arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _replace7637;
		public static global::java.lang.CharSequence replace(java.lang.CharSequence arg0, java.lang.String[] arg1, java.lang.CharSequence[] arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallStaticObjectMethodPtr(android.text.TextUtils.staticClass, global::android.text.TextUtils._replace7637, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.CharSequence[], java.lang.CharSequence>(@__env, arg2)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _split7638;
		public static global::java.lang.String[] split(java.lang.String arg0, java.lang.String arg1) 
		{
			return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.text.TextUtils.staticClass, global::android.text.TextUtils._split7638, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _split7639;
		public static global::java.lang.String[] split(java.lang.String arg0, java.util.regex.Pattern arg1) 
		{
			return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.text.TextUtils.staticClass, global::android.text.TextUtils._split7639, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _join7640;
		public static global::java.lang.String join(java.lang.CharSequence arg0, java.lang.Object[] arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.text.TextUtils.staticClass, global::android.text.TextUtils._join7640, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.Object[], java.lang.Object>(@__env, arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _join7641;
		public static global::java.lang.String join(java.lang.CharSequence arg0, java.lang.Iterable arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.text.TextUtils.staticClass, global::android.text.TextUtils._join7641, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _ellipsize7642;
		public static global::java.lang.CharSequence ellipsize(java.lang.CharSequence arg0, android.text.TextPaint arg1, float arg2, android.text.TextUtils.TruncateAt arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallStaticObjectMethodPtr(android.text.TextUtils.staticClass, global::android.text.TextUtils._ellipsize7642, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _ellipsize7643;
		public static global::java.lang.CharSequence ellipsize(java.lang.CharSequence arg0, android.text.TextPaint arg1, float arg2, android.text.TextUtils.TruncateAt arg3, bool arg4, android.text.TextUtils.EllipsizeCallback arg5) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallStaticObjectMethodPtr(android.text.TextUtils.staticClass, global::android.text.TextUtils._ellipsize7643, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg5)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel7644;
		public static void writeToParcel(java.lang.CharSequence arg0, android.os.Parcel arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._writeToParcel7644, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _stringOrSpannedString7645;
		public static global::java.lang.CharSequence stringOrSpannedString(java.lang.CharSequence arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallStaticObjectMethodPtr(android.text.TextUtils.staticClass, global::android.text.TextUtils._stringOrSpannedString7645, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getTrimmedLength7646;
		public static int getTrimmedLength(java.lang.CharSequence arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._getTrimmedLength7646, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getReverse7647;
		public static global::java.lang.CharSequence getReverse(java.lang.CharSequence arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallStaticObjectMethodPtr(android.text.TextUtils.staticClass, global::android.text.TextUtils._getReverse7647, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _dumpSpans7648;
		public static void dumpSpans(java.lang.CharSequence arg0, android.util.Printer arg1, java.lang.String arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._dumpSpans7648, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _expandTemplate7649;
		public static global::java.lang.CharSequence expandTemplate(java.lang.CharSequence arg0, java.lang.CharSequence[] arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallStaticObjectMethodPtr(android.text.TextUtils.staticClass, global::android.text.TextUtils._expandTemplate7649, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.CharSequence[], java.lang.CharSequence>(@__env, arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getOffsetBefore7650;
		public static int getOffsetBefore(java.lang.CharSequence arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._getOffsetBefore7650, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getOffsetAfter7651;
		public static int getOffsetAfter(java.lang.CharSequence arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._getOffsetAfter7651, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _copySpansFrom7652;
		public static void copySpansFrom(android.text.Spanned arg0, int arg1, int arg2, java.lang.Class arg3, android.text.Spannable arg4, int arg5) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._copySpansFrom7652, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5));
		}
		internal static global::net.sf.jni4net.jni.MethodId _commaEllipsize7653;
		public static global::java.lang.CharSequence commaEllipsize(java.lang.CharSequence arg0, android.text.TextPaint arg1, float arg2, java.lang.String arg3, java.lang.String arg4) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallStaticObjectMethodPtr(android.text.TextUtils.staticClass, global::android.text.TextUtils._commaEllipsize7653, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _htmlEncode7654;
		public static global::java.lang.String htmlEncode(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.text.TextUtils.staticClass, global::android.text.TextUtils._htmlEncode7654, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isGraphic7655;
		public static bool isGraphic(java.lang.CharSequence arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._isGraphic7655, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isGraphic7656;
		public static bool isGraphic(char arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._isGraphic7656, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isDigitsOnly7657;
		public static bool isDigitsOnly(java.lang.CharSequence arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._isDigitsOnly7657, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getCapsMode7658;
		public static int getCapsMode(java.lang.CharSequence arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.text.TextUtils.staticClass, global::android.text.TextUtils._getCapsMode7658, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.FieldId _CHAR_SEQUENCE_CREATOR7659;
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
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.text.TextUtils.staticClass = @__class;
			global::android.text.TextUtils._equals7622 = @__env.GetStaticMethodID(global::android.text.TextUtils.staticClass, "equals", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Z");
			global::android.text.TextUtils._indexOf7623 = @__env.GetStaticMethodID(global::android.text.TextUtils.staticClass, "indexOf", "(Ljava/lang/CharSequence;CI)I");
			global::android.text.TextUtils._indexOf7624 = @__env.GetStaticMethodID(global::android.text.TextUtils.staticClass, "indexOf", "(Ljava/lang/CharSequence;CII)I");
			global::android.text.TextUtils._indexOf7625 = @__env.GetStaticMethodID(global::android.text.TextUtils.staticClass, "indexOf", "(Ljava/lang/CharSequence;C)I");
			global::android.text.TextUtils._indexOf7626 = @__env.GetStaticMethodID(global::android.text.TextUtils.staticClass, "indexOf", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)I");
			global::android.text.TextUtils._indexOf7627 = @__env.GetStaticMethodID(global::android.text.TextUtils.staticClass, "indexOf", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;I)I");
			global::android.text.TextUtils._indexOf7628 = @__env.GetStaticMethodID(global::android.text.TextUtils.staticClass, "indexOf", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;II)I");
			global::android.text.TextUtils._isEmpty7629 = @__env.GetStaticMethodID(global::android.text.TextUtils.staticClass, "isEmpty", "(Ljava/lang/CharSequence;)Z");
			global::android.text.TextUtils._getChars7630 = @__env.GetStaticMethodID(global::android.text.TextUtils.staticClass, "getChars", "(Ljava/lang/CharSequence;II[CI)V");
			global::android.text.TextUtils._regionMatches7631 = @__env.GetStaticMethodID(global::android.text.TextUtils.staticClass, "regionMatches", "(Ljava/lang/CharSequence;ILjava/lang/CharSequence;II)Z");
			global::android.text.TextUtils._lastIndexOf7632 = @__env.GetStaticMethodID(global::android.text.TextUtils.staticClass, "lastIndexOf", "(Ljava/lang/CharSequence;CI)I");
			global::android.text.TextUtils._lastIndexOf7633 = @__env.GetStaticMethodID(global::android.text.TextUtils.staticClass, "lastIndexOf", "(Ljava/lang/CharSequence;CII)I");
			global::android.text.TextUtils._lastIndexOf7634 = @__env.GetStaticMethodID(global::android.text.TextUtils.staticClass, "lastIndexOf", "(Ljava/lang/CharSequence;C)I");
			global::android.text.TextUtils._substring7635 = @__env.GetStaticMethodID(global::android.text.TextUtils.staticClass, "substring", "(Ljava/lang/CharSequence;II)Ljava/lang/String;");
			global::android.text.TextUtils._concat7636 = @__env.GetStaticMethodID(global::android.text.TextUtils.staticClass, "concat", "([Ljava/lang/CharSequence;)Ljava/lang/CharSequence;");
			global::android.text.TextUtils._replace7637 = @__env.GetStaticMethodID(global::android.text.TextUtils.staticClass, "replace", "(Ljava/lang/CharSequence;[Ljava/lang/String;[Ljava/lang/CharSequence;)Ljava/lang/CharSequence;");
			global::android.text.TextUtils._split7638 = @__env.GetStaticMethodID(global::android.text.TextUtils.staticClass, "split", "(Ljava/lang/String;Ljava/lang/String;)[Ljava/lang/String;");
			global::android.text.TextUtils._split7639 = @__env.GetStaticMethodID(global::android.text.TextUtils.staticClass, "split", "(Ljava/lang/String;Ljava/util/regex/Pattern;)[Ljava/lang/String;");
			global::android.text.TextUtils._join7640 = @__env.GetStaticMethodID(global::android.text.TextUtils.staticClass, "join", "(Ljava/lang/CharSequence;[Ljava/lang/Object;)Ljava/lang/String;");
			global::android.text.TextUtils._join7641 = @__env.GetStaticMethodID(global::android.text.TextUtils.staticClass, "join", "(Ljava/lang/CharSequence;Ljava/lang/Iterable;)Ljava/lang/String;");
			global::android.text.TextUtils._ellipsize7642 = @__env.GetStaticMethodID(global::android.text.TextUtils.staticClass, "ellipsize", "(Ljava/lang/CharSequence;Landroid/text/TextPaint;FLandroid/text/TextUtils$TruncateAt;)Ljava/lang/CharSequence;");
			global::android.text.TextUtils._ellipsize7643 = @__env.GetStaticMethodID(global::android.text.TextUtils.staticClass, "ellipsize", "(Ljava/lang/CharSequence;Landroid/text/TextPaint;FLandroid/text/TextUtils$TruncateAt;ZLandroid/text/TextUtils$EllipsizeCallback;)Ljava/lang/CharSequence;");
			global::android.text.TextUtils._writeToParcel7644 = @__env.GetStaticMethodID(global::android.text.TextUtils.staticClass, "writeToParcel", "(Ljava/lang/CharSequence;Landroid/os/Parcel;I)V");
			global::android.text.TextUtils._stringOrSpannedString7645 = @__env.GetStaticMethodID(global::android.text.TextUtils.staticClass, "stringOrSpannedString", "(Ljava/lang/CharSequence;)Ljava/lang/CharSequence;");
			global::android.text.TextUtils._getTrimmedLength7646 = @__env.GetStaticMethodID(global::android.text.TextUtils.staticClass, "getTrimmedLength", "(Ljava/lang/CharSequence;)I");
			global::android.text.TextUtils._getReverse7647 = @__env.GetStaticMethodID(global::android.text.TextUtils.staticClass, "getReverse", "(Ljava/lang/CharSequence;II)Ljava/lang/CharSequence;");
			global::android.text.TextUtils._dumpSpans7648 = @__env.GetStaticMethodID(global::android.text.TextUtils.staticClass, "dumpSpans", "(Ljava/lang/CharSequence;Landroid/util/Printer;Ljava/lang/String;)V");
			global::android.text.TextUtils._expandTemplate7649 = @__env.GetStaticMethodID(global::android.text.TextUtils.staticClass, "expandTemplate", "(Ljava/lang/CharSequence;[Ljava/lang/CharSequence;)Ljava/lang/CharSequence;");
			global::android.text.TextUtils._getOffsetBefore7650 = @__env.GetStaticMethodID(global::android.text.TextUtils.staticClass, "getOffsetBefore", "(Ljava/lang/CharSequence;I)I");
			global::android.text.TextUtils._getOffsetAfter7651 = @__env.GetStaticMethodID(global::android.text.TextUtils.staticClass, "getOffsetAfter", "(Ljava/lang/CharSequence;I)I");
			global::android.text.TextUtils._copySpansFrom7652 = @__env.GetStaticMethodID(global::android.text.TextUtils.staticClass, "copySpansFrom", "(Landroid/text/Spanned;IILjava/lang/Class;Landroid/text/Spannable;I)V");
			global::android.text.TextUtils._commaEllipsize7653 = @__env.GetStaticMethodID(global::android.text.TextUtils.staticClass, "commaEllipsize", "(Ljava/lang/CharSequence;Landroid/text/TextPaint;FLjava/lang/String;Ljava/lang/String;)Ljava/lang/CharSequence;");
			global::android.text.TextUtils._htmlEncode7654 = @__env.GetStaticMethodID(global::android.text.TextUtils.staticClass, "htmlEncode", "(Ljava/lang/String;)Ljava/lang/String;");
			global::android.text.TextUtils._isGraphic7655 = @__env.GetStaticMethodID(global::android.text.TextUtils.staticClass, "isGraphic", "(Ljava/lang/CharSequence;)Z");
			global::android.text.TextUtils._isGraphic7656 = @__env.GetStaticMethodID(global::android.text.TextUtils.staticClass, "isGraphic", "(C)Z");
			global::android.text.TextUtils._isDigitsOnly7657 = @__env.GetStaticMethodID(global::android.text.TextUtils.staticClass, "isDigitsOnly", "(Ljava/lang/CharSequence;)Z");
			global::android.text.TextUtils._getCapsMode7658 = @__env.GetStaticMethodID(global::android.text.TextUtils.staticClass, "getCapsMode", "(Ljava/lang/CharSequence;II)I");
		}
	}
}
