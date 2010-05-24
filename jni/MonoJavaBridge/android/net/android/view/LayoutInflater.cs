namespace android.view 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class LayoutInflater : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static LayoutInflater() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.view.LayoutInflater), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		protected LayoutInflater(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface Factory 
		{ 
			android.view.View onCreateView(java.lang.String arg0, android.content.Context arg1, android.util.AttributeSet arg2); 
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
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.view.LayoutInflater.__Factory), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
			internal static global::net.sf.jni4net.jni.MethodId _onCreateView7861; 
			 android.view.View android.view.LayoutInflater.Factory.onCreateView(java.lang.String arg0, android.content.Context arg1, android.util.AttributeSet arg2) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.view.LayoutInflater.__Factory)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, _onCreateView7861, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2))); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.LayoutInflater.__Factory.staticClass, _onCreateView7861, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2))); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.view.LayoutInflater.__Factory.staticClass = @__class; 
				global::android.view.LayoutInflater.__Factory._onCreateView7861 = @__env.GetMethodID(global::android.view.LayoutInflater.__Factory.staticClass, "android.view.LayoutInflater.Factory.onCreateView", "(Ljava/lang/String;Landroid/content/Context;Landroid/util/AttributeSet;)Landroid/view/View;"); 
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
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.view.LayoutInflater.__Filter), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
			internal static global::net.sf.jni4net.jni.MethodId _onLoadClass7862; 
			 bool android.view.LayoutInflater.Filter.onLoadClass(java.lang.Class arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.view.LayoutInflater.__Filter)) 
					return @__env.CallBooleanMethod(this, _onLoadClass7862, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
				else 
					return @__env.CallNonVirtualBooleanMethod(this, android.view.LayoutInflater.__Filter.staticClass, _onLoadClass7862, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.view.LayoutInflater.__Filter.staticClass = @__class; 
				global::android.view.LayoutInflater.__Filter._onLoadClass7862 = @__env.GetMethodID(global::android.view.LayoutInflater.__Filter.staticClass, "android.view.LayoutInflater.Filter.onLoadClass", "(Ljava/lang/Class;)Z"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _from7863; 
		public static android.view.LayoutInflater from(android.content.Context arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.LayoutInflater>(@__env, @__env.CallStaticObjectMethodPtr(android.view.LayoutInflater.staticClass, _from7863, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getFactory7864; 
		public virtual android.view.LayoutInflater.Factory getFactory() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.LayoutInflater)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.LayoutInflater.Factory>(@__env, @__env.CallObjectMethodPtr(this, _getFactory7864)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.LayoutInflater.Factory>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.LayoutInflater.staticClass, _getFactory7864)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getContext7865; 
		public virtual android.content.Context getContext() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.LayoutInflater)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Context>(@__env, @__env.CallObjectMethodPtr(this, _getContext7865)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Context>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.LayoutInflater.staticClass, _getContext7865)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _inflate7866; 
		public virtual android.view.View inflate(org.xmlpull.v1.XmlPullParser arg0, android.view.ViewGroup arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.LayoutInflater)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, _inflate7866, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.LayoutInflater.staticClass, _inflate7866, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _inflate7867; 
		public virtual android.view.View inflate(org.xmlpull.v1.XmlPullParser arg0, android.view.ViewGroup arg1, bool arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.LayoutInflater)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, _inflate7867, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.LayoutInflater.staticClass, _inflate7867, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _inflate7868; 
		public virtual android.view.View inflate(int arg0, android.view.ViewGroup arg1, bool arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.LayoutInflater)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, _inflate7868, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.LayoutInflater.staticClass, _inflate7868, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _inflate7869; 
		public virtual android.view.View inflate(int arg0, android.view.ViewGroup arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.LayoutInflater)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, _inflate7869, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.LayoutInflater.staticClass, _inflate7869, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onCreateView7870; 
		protected virtual android.view.View onCreateView(java.lang.String arg0, android.util.AttributeSet arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.LayoutInflater)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, _onCreateView7870, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.LayoutInflater.staticClass, _onCreateView7870, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _cloneInContext7871; 
		public abstract android.view.LayoutInflater cloneInContext(android.content.Context arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _setFactory7872; 
		public virtual void setFactory(android.view.LayoutInflater.Factory arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.LayoutInflater)) 
				@__env.CallVoidMethod(this, _setFactory7872, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.LayoutInflater.staticClass, _setFactory7872, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getFilter7873; 
		public virtual android.view.LayoutInflater.Filter getFilter() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.LayoutInflater)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.LayoutInflater.Filter>(@__env, @__env.CallObjectMethodPtr(this, _getFilter7873)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.LayoutInflater.Filter>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.LayoutInflater.staticClass, _getFilter7873)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setFilter7874; 
		public virtual void setFilter(android.view.LayoutInflater.Filter arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.LayoutInflater)) 
				@__env.CallVoidMethod(this, _setFilter7874, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.LayoutInflater.staticClass, _setFilter7874, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _createView7875; 
		public virtual android.view.View createView(java.lang.String arg0, java.lang.String arg1, android.util.AttributeSet arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.LayoutInflater)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, _createView7875, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.LayoutInflater.staticClass, _createView7875, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _LayoutInflater7876; 
		protected LayoutInflater(android.view.LayoutInflater arg0, android.content.Context arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.view.LayoutInflater.staticClass, _LayoutInflater7876, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _LayoutInflater7877; 
		protected LayoutInflater(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.view.LayoutInflater.staticClass, _LayoutInflater7877, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.view.LayoutInflater.staticClass = @__class; 
			global::android.view.LayoutInflater._from7863 = @__env.GetStaticMethodID(global::android.view.LayoutInflater.staticClass, "from", "(Landroid/content/Context;)Landroid/view/LayoutInflater;"); 
			global::android.view.LayoutInflater._getFactory7864 = @__env.GetMethodID(global::android.view.LayoutInflater.staticClass, "getFactory", "()Landroid/view/LayoutInflater$Factory;"); 
			global::android.view.LayoutInflater._getContext7865 = @__env.GetMethodID(global::android.view.LayoutInflater.staticClass, "getContext", "()Landroid/content/Context;"); 
			global::android.view.LayoutInflater._inflate7866 = @__env.GetMethodID(global::android.view.LayoutInflater.staticClass, "inflate", "(Lorg/xmlpull/v1/XmlPullParser;Landroid/view/ViewGroup;)Landroid/view/View;"); 
			global::android.view.LayoutInflater._inflate7867 = @__env.GetMethodID(global::android.view.LayoutInflater.staticClass, "inflate", "(Lorg/xmlpull/v1/XmlPullParser;Landroid/view/ViewGroup;Z)Landroid/view/View;"); 
			global::android.view.LayoutInflater._inflate7868 = @__env.GetMethodID(global::android.view.LayoutInflater.staticClass, "inflate", "(ILandroid/view/ViewGroup;Z)Landroid/view/View;"); 
			global::android.view.LayoutInflater._inflate7869 = @__env.GetMethodID(global::android.view.LayoutInflater.staticClass, "inflate", "(ILandroid/view/ViewGroup;)Landroid/view/View;"); 
			global::android.view.LayoutInflater._onCreateView7870 = @__env.GetMethodID(global::android.view.LayoutInflater.staticClass, "onCreateView", "(Ljava/lang/String;Landroid/util/AttributeSet;)Landroid/view/View;"); 
			global::android.view.LayoutInflater._cloneInContext7871 = @__env.GetMethodID(global::android.view.LayoutInflater.staticClass, "cloneInContext", "(Landroid/content/Context;)Landroid/view/LayoutInflater;"); 
			global::android.view.LayoutInflater._setFactory7872 = @__env.GetMethodID(global::android.view.LayoutInflater.staticClass, "setFactory", "(Landroid/view/LayoutInflater$Factory;)V"); 
			global::android.view.LayoutInflater._getFilter7873 = @__env.GetMethodID(global::android.view.LayoutInflater.staticClass, "getFilter", "()Landroid/view/LayoutInflater$Filter;"); 
			global::android.view.LayoutInflater._setFilter7874 = @__env.GetMethodID(global::android.view.LayoutInflater.staticClass, "setFilter", "(Landroid/view/LayoutInflater$Filter;)V"); 
			global::android.view.LayoutInflater._createView7875 = @__env.GetMethodID(global::android.view.LayoutInflater.staticClass, "createView", "(Ljava/lang/String;Ljava/lang/String;Landroid/util/AttributeSet;)Landroid/view/View;"); 
			global::android.view.LayoutInflater._LayoutInflater7876 = @__env.GetMethodID(global::android.view.LayoutInflater.staticClass, "<init>", "(Landroid/view/LayoutInflater;Landroid/content/Context;)V"); 
			global::android.view.LayoutInflater._LayoutInflater7877 = @__env.GetMethodID(global::android.view.LayoutInflater.staticClass, "<init>", "(Landroid/content/Context;)V"); 
		} 
	} 
} 
