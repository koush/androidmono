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
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface Filter 
		{ 
			bool onLoadClass(java.lang.Class arg0); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _from7415; 
		public static android.view.LayoutInflater from(android.content.Context arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.LayoutInflater>(@__env, @__env.CallStaticObjectMethodPtr(android.view.LayoutInflater.staticClass, _from7415, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getFactory7416; 
		public virtual android.view.LayoutInflater.Factory getFactory() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.LayoutInflater)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.LayoutInflater.Factory>(@__env, @__env.CallObjectMethodPtr(this, _getFactory7416)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.LayoutInflater.Factory>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.LayoutInflater.staticClass, _getFactory7416)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getContext7417; 
		public virtual android.content.Context getContext() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.LayoutInflater)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Context>(@__env, @__env.CallObjectMethodPtr(this, _getContext7417)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Context>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.LayoutInflater.staticClass, _getContext7417)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _inflate7418; 
		public virtual android.view.View inflate(org.xmlpull.v1.XmlPullParser arg0, android.view.ViewGroup arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.LayoutInflater)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, _inflate7418, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.LayoutInflater.staticClass, _inflate7418, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _inflate7419; 
		public virtual android.view.View inflate(org.xmlpull.v1.XmlPullParser arg0, android.view.ViewGroup arg1, bool arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.LayoutInflater)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, _inflate7419, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.LayoutInflater.staticClass, _inflate7419, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _inflate7420; 
		public virtual android.view.View inflate(int arg0, android.view.ViewGroup arg1, bool arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.LayoutInflater)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, _inflate7420, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.LayoutInflater.staticClass, _inflate7420, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _inflate7421; 
		public virtual android.view.View inflate(int arg0, android.view.ViewGroup arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.LayoutInflater)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, _inflate7421, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.LayoutInflater.staticClass, _inflate7421, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onCreateView7422; 
		protected virtual android.view.View onCreateView(java.lang.String arg0, android.util.AttributeSet arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.LayoutInflater)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, _onCreateView7422, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.LayoutInflater.staticClass, _onCreateView7422, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _cloneInContext7423; 
		public abstract android.view.LayoutInflater cloneInContext(android.content.Context arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _setFactory7424; 
		public virtual void setFactory(android.view.LayoutInflater.Factory arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.LayoutInflater)) 
				@__env.CallVoidMethod(this, _setFactory7424, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.LayoutInflater.staticClass, _setFactory7424, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getFilter7425; 
		public virtual android.view.LayoutInflater.Filter getFilter() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.LayoutInflater)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.LayoutInflater.Filter>(@__env, @__env.CallObjectMethodPtr(this, _getFilter7425)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.LayoutInflater.Filter>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.LayoutInflater.staticClass, _getFilter7425)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setFilter7426; 
		public virtual void setFilter(android.view.LayoutInflater.Filter arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.LayoutInflater)) 
				@__env.CallVoidMethod(this, _setFilter7426, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.LayoutInflater.staticClass, _setFilter7426, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _createView7427; 
		public virtual android.view.View createView(java.lang.String arg0, java.lang.String arg1, android.util.AttributeSet arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.LayoutInflater)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, _createView7427, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.LayoutInflater.staticClass, _createView7427, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _LayoutInflater7428; 
		protected LayoutInflater(android.view.LayoutInflater arg0, android.content.Context arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.view.LayoutInflater.staticClass, _LayoutInflater7428, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _LayoutInflater7429; 
		protected LayoutInflater(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.view.LayoutInflater.staticClass, _LayoutInflater7429, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.view.LayoutInflater.staticClass = @__class; 
			global::android.view.LayoutInflater._from7415 = @__env.GetStaticMethodID(global::android.view.LayoutInflater.staticClass, "from", "(Landroid/content/Context;)Landroid/view/LayoutInflater;"); 
			global::android.view.LayoutInflater._getFactory7416 = @__env.GetMethodID(global::android.view.LayoutInflater.staticClass, "getFactory", "()Landroid/view/LayoutInflater$Factory;"); 
			global::android.view.LayoutInflater._getContext7417 = @__env.GetMethodID(global::android.view.LayoutInflater.staticClass, "getContext", "()Landroid/content/Context;"); 
			global::android.view.LayoutInflater._inflate7418 = @__env.GetMethodID(global::android.view.LayoutInflater.staticClass, "inflate", "(Lorg/xmlpull/v1/XmlPullParser;Landroid/view/ViewGroup;)Landroid/view/View;"); 
			global::android.view.LayoutInflater._inflate7419 = @__env.GetMethodID(global::android.view.LayoutInflater.staticClass, "inflate", "(Lorg/xmlpull/v1/XmlPullParser;Landroid/view/ViewGroup;Z)Landroid/view/View;"); 
			global::android.view.LayoutInflater._inflate7420 = @__env.GetMethodID(global::android.view.LayoutInflater.staticClass, "inflate", "(ILandroid/view/ViewGroup;Z)Landroid/view/View;"); 
			global::android.view.LayoutInflater._inflate7421 = @__env.GetMethodID(global::android.view.LayoutInflater.staticClass, "inflate", "(ILandroid/view/ViewGroup;)Landroid/view/View;"); 
			global::android.view.LayoutInflater._onCreateView7422 = @__env.GetMethodID(global::android.view.LayoutInflater.staticClass, "onCreateView", "(Ljava/lang/String;Landroid/util/AttributeSet;)Landroid/view/View;"); 
			global::android.view.LayoutInflater._cloneInContext7423 = @__env.GetMethodID(global::android.view.LayoutInflater.staticClass, "cloneInContext", "(Landroid/content/Context;)Landroid/view/LayoutInflater;"); 
			global::android.view.LayoutInflater._setFactory7424 = @__env.GetMethodID(global::android.view.LayoutInflater.staticClass, "setFactory", "(Landroid/view/LayoutInflater$Factory;)V"); 
			global::android.view.LayoutInflater._getFilter7425 = @__env.GetMethodID(global::android.view.LayoutInflater.staticClass, "getFilter", "()Landroid/view/LayoutInflater$Filter;"); 
			global::android.view.LayoutInflater._setFilter7426 = @__env.GetMethodID(global::android.view.LayoutInflater.staticClass, "setFilter", "(Landroid/view/LayoutInflater$Filter;)V"); 
			global::android.view.LayoutInflater._createView7427 = @__env.GetMethodID(global::android.view.LayoutInflater.staticClass, "createView", "(Ljava/lang/String;Ljava/lang/String;Landroid/util/AttributeSet;)Landroid/view/View;"); 
			global::android.view.LayoutInflater._LayoutInflater7428 = @__env.GetMethodID(global::android.view.LayoutInflater.staticClass, "<init>", "(Landroid/view/LayoutInflater;Landroid/content/Context;)V"); 
			global::android.view.LayoutInflater._LayoutInflater7429 = @__env.GetMethodID(global::android.view.LayoutInflater.staticClass, "<init>", "(Landroid/content/Context;)V"); 
		} 
	} 
} 
