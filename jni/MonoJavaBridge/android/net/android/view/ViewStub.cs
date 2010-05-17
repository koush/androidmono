namespace android.view 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class ViewStub : android.view.View
	{ 
		internal new static global::java.lang.Class staticClass; 
		static ViewStub() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.view.ViewStub), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.view.ViewStub(@__env); 
			} 
		} 
		internal ViewStub(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface OnInflateListener 
		{ 
			void onInflate(android.view.ViewStub arg0, android.view.View arg1); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _inflate8021; 
		public android.view.View inflate() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewStub)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, _inflate8021)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.ViewStub.staticClass, _inflate8021)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _draw8022; 
		public sealed override void draw(android.graphics.Canvas arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewStub)) 
				@__env.CallVoidMethod(this, _draw8022, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.ViewStub.staticClass, _draw8022, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setVisibility8023; 
		public sealed override void setVisibility(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewStub)) 
				@__env.CallVoidMethod(this, _setVisibility8023, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.ViewStub.staticClass, _setVisibility8023, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setLayoutResource8024; 
		public void setLayoutResource(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewStub)) 
				@__env.CallVoidMethod(this, _setLayoutResource8024, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.ViewStub.staticClass, _setLayoutResource8024, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLayoutResource8025; 
		public int getLayoutResource() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewStub)) 
				return @__env.CallIntMethod(this, _getLayoutResource8025); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.view.ViewStub.staticClass, _getLayoutResource8025); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getInflatedId8026; 
		public int getInflatedId() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewStub)) 
				return @__env.CallIntMethod(this, _getInflatedId8026); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.view.ViewStub.staticClass, _getInflatedId8026); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setInflatedId8027; 
		public void setInflatedId(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewStub)) 
				@__env.CallVoidMethod(this, _setInflatedId8027, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.ViewStub.staticClass, _setInflatedId8027, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setOnInflateListener8028; 
		public void setOnInflateListener(android.view.ViewStub.OnInflateListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewStub)) 
				@__env.CallVoidMethod(this, _setOnInflateListener8028, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.ViewStub.staticClass, _setOnInflateListener8028, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ViewStub8029; 
		public ViewStub(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.view.ViewStub.staticClass, _ViewStub8029, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ViewStub8030; 
		public ViewStub(android.content.Context arg0, int arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.view.ViewStub.staticClass, _ViewStub8030, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ViewStub8031; 
		public ViewStub(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.view.ViewStub.staticClass, _ViewStub8031, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ViewStub8032; 
		public ViewStub(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.view.ViewStub.staticClass, _ViewStub8032, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.view.ViewStub.staticClass = @__class; 
			global::android.view.ViewStub._inflate8021 = @__env.GetMethodID(global::android.view.ViewStub.staticClass, "inflate", "()Landroid/view/View;"); 
			global::android.view.ViewStub._draw8022 = @__env.GetMethodID(global::android.view.ViewStub.staticClass, "draw", "(Landroid/graphics/Canvas;)V"); 
			global::android.view.ViewStub._setVisibility8023 = @__env.GetMethodID(global::android.view.ViewStub.staticClass, "setVisibility", "(I)V"); 
			global::android.view.ViewStub._setLayoutResource8024 = @__env.GetMethodID(global::android.view.ViewStub.staticClass, "setLayoutResource", "(I)V"); 
			global::android.view.ViewStub._getLayoutResource8025 = @__env.GetMethodID(global::android.view.ViewStub.staticClass, "getLayoutResource", "()I"); 
			global::android.view.ViewStub._getInflatedId8026 = @__env.GetMethodID(global::android.view.ViewStub.staticClass, "getInflatedId", "()I"); 
			global::android.view.ViewStub._setInflatedId8027 = @__env.GetMethodID(global::android.view.ViewStub.staticClass, "setInflatedId", "(I)V"); 
			global::android.view.ViewStub._setOnInflateListener8028 = @__env.GetMethodID(global::android.view.ViewStub.staticClass, "setOnInflateListener", "(Landroid/view/ViewStub$OnInflateListener;)V"); 
			global::android.view.ViewStub._ViewStub8029 = @__env.GetMethodID(global::android.view.ViewStub.staticClass, "<init>", "(Landroid/content/Context;)V"); 
			global::android.view.ViewStub._ViewStub8030 = @__env.GetMethodID(global::android.view.ViewStub.staticClass, "<init>", "(Landroid/content/Context;I)V"); 
			global::android.view.ViewStub._ViewStub8031 = @__env.GetMethodID(global::android.view.ViewStub.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V"); 
			global::android.view.ViewStub._ViewStub8032 = @__env.GetMethodID(global::android.view.ViewStub.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V"); 
		} 
	} 
} 
