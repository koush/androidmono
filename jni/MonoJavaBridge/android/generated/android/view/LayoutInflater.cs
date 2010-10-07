namespace android.view
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public abstract class LayoutInflater : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static LayoutInflater()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.view.LayoutInflater), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		protected LayoutInflater(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
		public interface Factory 
		{
			global::android.view.View onCreateView(java.lang.String arg0, android.content.Context arg1, android.util.AttributeSet arg2);
		}

		public partial class Factory_
		{
			public static global::java.lang.Class _class
			{
				get { return __Factory.staticClass; }
			}
		}

		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public sealed class __Factory : java.lang.Object, Factory
		{
			internal static global::java.lang.Class staticClass;
			static __Factory()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.view.LayoutInflater.__Factory), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.view.LayoutInflater.__Factory(@__env);
				}
			}
			internal __Factory(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _onCreateView8537;
			 global::android.view.View android.view.LayoutInflater.Factory.onCreateView(java.lang.String arg0, android.content.Context arg1, android.util.AttributeSet arg2) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.LayoutInflater.__Factory._onCreateView8537, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.LayoutInflater.__Factory.staticClass, global::android.view.LayoutInflater.__Factory._onCreateView8537, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.view.LayoutInflater.__Factory.staticClass = @__class;
				global::android.view.LayoutInflater.__Factory._onCreateView8537 = @__env.GetMethodID(global::android.view.LayoutInflater.__Factory.staticClass, "android.view.LayoutInflater.Factory.onCreateView", "(Ljava/lang/String;Landroid/content/Context;Landroid/util/AttributeSet;)Landroid/view/View;");
			}
		}
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
		public interface Filter 
		{
			bool onLoadClass(java.lang.Class arg0);
		}

		public partial class Filter_
		{
			public static global::java.lang.Class _class
			{
				get { return __Filter.staticClass; }
			}
		}

		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public sealed class __Filter : java.lang.Object, Filter
		{
			internal static global::java.lang.Class staticClass;
			static __Filter()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.view.LayoutInflater.__Filter), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.view.LayoutInflater.__Filter(@__env);
				}
			}
			internal __Filter(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _onLoadClass8538;
			 bool android.view.LayoutInflater.Filter.onLoadClass(java.lang.Class arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this, global::android.view.LayoutInflater.__Filter._onLoadClass8538, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this, global::android.view.LayoutInflater.__Filter.staticClass, global::android.view.LayoutInflater.__Filter._onLoadClass8538, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.view.LayoutInflater.__Filter.staticClass = @__class;
				global::android.view.LayoutInflater.__Filter._onLoadClass8538 = @__env.GetMethodID(global::android.view.LayoutInflater.__Filter.staticClass, "android.view.LayoutInflater.Filter.onLoadClass", "(Ljava/lang/Class;)Z");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _from8539;
		public static global::android.view.LayoutInflater from(android.content.Context arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.LayoutInflater>(@__env, @__env.CallStaticObjectMethodPtr(android.view.LayoutInflater.staticClass, global::android.view.LayoutInflater._from8539, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getFactory8540;
		public virtual global::android.view.LayoutInflater.Factory getFactory() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.LayoutInflater.Factory>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.LayoutInflater._getFactory8540));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.LayoutInflater.Factory>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.LayoutInflater.staticClass, global::android.view.LayoutInflater._getFactory8540));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getContext8541;
		public virtual global::android.content.Context getContext() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Context>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.LayoutInflater._getContext8541));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Context>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.LayoutInflater.staticClass, global::android.view.LayoutInflater._getContext8541));
		}
		internal static global::net.sf.jni4net.jni.MethodId _inflate8542;
		public virtual global::android.view.View inflate(org.xmlpull.v1.XmlPullParser arg0, android.view.ViewGroup arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.LayoutInflater._inflate8542, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.LayoutInflater.staticClass, global::android.view.LayoutInflater._inflate8542, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _inflate8543;
		public virtual global::android.view.View inflate(org.xmlpull.v1.XmlPullParser arg0, android.view.ViewGroup arg1, bool arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.LayoutInflater._inflate8543, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.LayoutInflater.staticClass, global::android.view.LayoutInflater._inflate8543, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _inflate8544;
		public virtual global::android.view.View inflate(int arg0, android.view.ViewGroup arg1, bool arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.LayoutInflater._inflate8544, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.LayoutInflater.staticClass, global::android.view.LayoutInflater._inflate8544, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _inflate8545;
		public virtual global::android.view.View inflate(int arg0, android.view.ViewGroup arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.LayoutInflater._inflate8545, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.LayoutInflater.staticClass, global::android.view.LayoutInflater._inflate8545, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onCreateView8546;
		protected virtual global::android.view.View onCreateView(java.lang.String arg0, android.util.AttributeSet arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.LayoutInflater._onCreateView8546, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.LayoutInflater.staticClass, global::android.view.LayoutInflater._onCreateView8546, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _cloneInContext8547;
		public abstract global::android.view.LayoutInflater cloneInContext(android.content.Context arg0);
		internal static global::net.sf.jni4net.jni.MethodId _setFactory8548;
		public virtual void setFactory(android.view.LayoutInflater.Factory arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.LayoutInflater._setFactory8548, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.LayoutInflater.staticClass, global::android.view.LayoutInflater._setFactory8548, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getFilter8549;
		public virtual global::android.view.LayoutInflater.Filter getFilter() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.LayoutInflater.Filter>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.LayoutInflater._getFilter8549));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.LayoutInflater.Filter>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.LayoutInflater.staticClass, global::android.view.LayoutInflater._getFilter8549));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setFilter8550;
		public virtual void setFilter(android.view.LayoutInflater.Filter arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.LayoutInflater._setFilter8550, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.LayoutInflater.staticClass, global::android.view.LayoutInflater._setFilter8550, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _createView8551;
		public virtual global::android.view.View createView(java.lang.String arg0, java.lang.String arg1, android.util.AttributeSet arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.LayoutInflater._createView8551, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.LayoutInflater.staticClass, global::android.view.LayoutInflater._createView8551, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _LayoutInflater8552;
		protected LayoutInflater(android.view.LayoutInflater arg0, android.content.Context arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.view.LayoutInflater.staticClass, global::android.view.LayoutInflater._LayoutInflater8552, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _LayoutInflater8553;
		protected LayoutInflater(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.view.LayoutInflater.staticClass, global::android.view.LayoutInflater._LayoutInflater8553, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.view.LayoutInflater.staticClass = @__class;
			global::android.view.LayoutInflater._from8539 = @__env.GetStaticMethodID(global::android.view.LayoutInflater.staticClass, "from", "(Landroid/content/Context;)Landroid/view/LayoutInflater;");
			global::android.view.LayoutInflater._getFactory8540 = @__env.GetMethodID(global::android.view.LayoutInflater.staticClass, "getFactory", "()Landroid/view/LayoutInflater$Factory;");
			global::android.view.LayoutInflater._getContext8541 = @__env.GetMethodID(global::android.view.LayoutInflater.staticClass, "getContext", "()Landroid/content/Context;");
			global::android.view.LayoutInflater._inflate8542 = @__env.GetMethodID(global::android.view.LayoutInflater.staticClass, "inflate", "(Lorg/xmlpull/v1/XmlPullParser;Landroid/view/ViewGroup;)Landroid/view/View;");
			global::android.view.LayoutInflater._inflate8543 = @__env.GetMethodID(global::android.view.LayoutInflater.staticClass, "inflate", "(Lorg/xmlpull/v1/XmlPullParser;Landroid/view/ViewGroup;Z)Landroid/view/View;");
			global::android.view.LayoutInflater._inflate8544 = @__env.GetMethodID(global::android.view.LayoutInflater.staticClass, "inflate", "(ILandroid/view/ViewGroup;Z)Landroid/view/View;");
			global::android.view.LayoutInflater._inflate8545 = @__env.GetMethodID(global::android.view.LayoutInflater.staticClass, "inflate", "(ILandroid/view/ViewGroup;)Landroid/view/View;");
			global::android.view.LayoutInflater._onCreateView8546 = @__env.GetMethodID(global::android.view.LayoutInflater.staticClass, "onCreateView", "(Ljava/lang/String;Landroid/util/AttributeSet;)Landroid/view/View;");
			global::android.view.LayoutInflater._cloneInContext8547 = @__env.GetMethodID(global::android.view.LayoutInflater.staticClass, "cloneInContext", "(Landroid/content/Context;)Landroid/view/LayoutInflater;");
			global::android.view.LayoutInflater._setFactory8548 = @__env.GetMethodID(global::android.view.LayoutInflater.staticClass, "setFactory", "(Landroid/view/LayoutInflater$Factory;)V");
			global::android.view.LayoutInflater._getFilter8549 = @__env.GetMethodID(global::android.view.LayoutInflater.staticClass, "getFilter", "()Landroid/view/LayoutInflater$Filter;");
			global::android.view.LayoutInflater._setFilter8550 = @__env.GetMethodID(global::android.view.LayoutInflater.staticClass, "setFilter", "(Landroid/view/LayoutInflater$Filter;)V");
			global::android.view.LayoutInflater._createView8551 = @__env.GetMethodID(global::android.view.LayoutInflater.staticClass, "createView", "(Ljava/lang/String;Ljava/lang/String;Landroid/util/AttributeSet;)Landroid/view/View;");
			global::android.view.LayoutInflater._LayoutInflater8552 = @__env.GetMethodID(global::android.view.LayoutInflater.staticClass, "<init>", "(Landroid/view/LayoutInflater;Landroid/content/Context;)V");
			global::android.view.LayoutInflater._LayoutInflater8553 = @__env.GetMethodID(global::android.view.LayoutInflater.staticClass, "<init>", "(Landroid/content/Context;)V");
		}
	}
}
