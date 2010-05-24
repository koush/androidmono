namespace android.widget 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class ViewFlipper : android.widget.ViewAnimator
	{ 
		internal new static global::java.lang.Class staticClass; 
		static ViewFlipper() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.widget.ViewFlipper), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.widget.ViewFlipper(@__env); 
			} 
		} 
		protected ViewFlipper(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onAttachedToWindow11311; 
		protected override void onAttachedToWindow() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ViewFlipper)) 
				@__env.CallVoidMethod(this, _onAttachedToWindow11311); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ViewFlipper.staticClass, _onAttachedToWindow11311); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onDetachedFromWindow11312; 
		protected override void onDetachedFromWindow() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ViewFlipper)) 
				@__env.CallVoidMethod(this, _onDetachedFromWindow11312); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ViewFlipper.staticClass, _onDetachedFromWindow11312); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onWindowVisibilityChanged11313; 
		protected override void onWindowVisibilityChanged(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ViewFlipper)) 
				@__env.CallVoidMethod(this, _onWindowVisibilityChanged11313, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ViewFlipper.staticClass, _onWindowVisibilityChanged11313, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setFlipInterval11314; 
		public virtual void setFlipInterval(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ViewFlipper)) 
				@__env.CallVoidMethod(this, _setFlipInterval11314, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ViewFlipper.staticClass, _setFlipInterval11314, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _startFlipping11315; 
		public virtual void startFlipping() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ViewFlipper)) 
				@__env.CallVoidMethod(this, _startFlipping11315); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ViewFlipper.staticClass, _startFlipping11315); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _stopFlipping11316; 
		public virtual void stopFlipping() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ViewFlipper)) 
				@__env.CallVoidMethod(this, _stopFlipping11316); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ViewFlipper.staticClass, _stopFlipping11316); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isFlipping11317; 
		public virtual bool isFlipping() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ViewFlipper)) 
				return @__env.CallBooleanMethod(this, _isFlipping11317); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.ViewFlipper.staticClass, _isFlipping11317); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setAutoStart11318; 
		public virtual void setAutoStart(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ViewFlipper)) 
				@__env.CallVoidMethod(this, _setAutoStart11318, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ViewFlipper.staticClass, _setAutoStart11318, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isAutoStart11319; 
		public virtual bool isAutoStart() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ViewFlipper)) 
				return @__env.CallBooleanMethod(this, _isAutoStart11319); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.ViewFlipper.staticClass, _isAutoStart11319); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ViewFlipper11320; 
		public ViewFlipper(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.ViewFlipper.staticClass, _ViewFlipper11320, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ViewFlipper11321; 
		public ViewFlipper(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.ViewFlipper.staticClass, _ViewFlipper11321, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.widget.ViewFlipper.staticClass = @__class; 
			global::android.widget.ViewFlipper._onAttachedToWindow11311 = @__env.GetMethodID(global::android.widget.ViewFlipper.staticClass, "onAttachedToWindow", "()V"); 
			global::android.widget.ViewFlipper._onDetachedFromWindow11312 = @__env.GetMethodID(global::android.widget.ViewFlipper.staticClass, "onDetachedFromWindow", "()V"); 
			global::android.widget.ViewFlipper._onWindowVisibilityChanged11313 = @__env.GetMethodID(global::android.widget.ViewFlipper.staticClass, "onWindowVisibilityChanged", "(I)V"); 
			global::android.widget.ViewFlipper._setFlipInterval11314 = @__env.GetMethodID(global::android.widget.ViewFlipper.staticClass, "setFlipInterval", "(I)V"); 
			global::android.widget.ViewFlipper._startFlipping11315 = @__env.GetMethodID(global::android.widget.ViewFlipper.staticClass, "startFlipping", "()V"); 
			global::android.widget.ViewFlipper._stopFlipping11316 = @__env.GetMethodID(global::android.widget.ViewFlipper.staticClass, "stopFlipping", "()V"); 
			global::android.widget.ViewFlipper._isFlipping11317 = @__env.GetMethodID(global::android.widget.ViewFlipper.staticClass, "isFlipping", "()Z"); 
			global::android.widget.ViewFlipper._setAutoStart11318 = @__env.GetMethodID(global::android.widget.ViewFlipper.staticClass, "setAutoStart", "(Z)V"); 
			global::android.widget.ViewFlipper._isAutoStart11319 = @__env.GetMethodID(global::android.widget.ViewFlipper.staticClass, "isAutoStart", "()Z"); 
			global::android.widget.ViewFlipper._ViewFlipper11320 = @__env.GetMethodID(global::android.widget.ViewFlipper.staticClass, "<init>", "(Landroid/content/Context;)V"); 
			global::android.widget.ViewFlipper._ViewFlipper11321 = @__env.GetMethodID(global::android.widget.ViewFlipper.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V"); 
		} 
	} 
} 
