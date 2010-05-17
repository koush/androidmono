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
		internal static global::net.sf.jni4net.jni.MethodId _onAttachedToWindow10506; 
		protected override void onAttachedToWindow() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ViewFlipper)) 
				@__env.CallVoidMethod(this, _onAttachedToWindow10506); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ViewFlipper.staticClass, _onAttachedToWindow10506); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onDetachedFromWindow10507; 
		protected override void onDetachedFromWindow() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ViewFlipper)) 
				@__env.CallVoidMethod(this, _onDetachedFromWindow10507); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ViewFlipper.staticClass, _onDetachedFromWindow10507); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onWindowVisibilityChanged10508; 
		protected override void onWindowVisibilityChanged(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ViewFlipper)) 
				@__env.CallVoidMethod(this, _onWindowVisibilityChanged10508, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ViewFlipper.staticClass, _onWindowVisibilityChanged10508, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setFlipInterval10509; 
		public virtual void setFlipInterval(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ViewFlipper)) 
				@__env.CallVoidMethod(this, _setFlipInterval10509, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ViewFlipper.staticClass, _setFlipInterval10509, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _startFlipping10510; 
		public virtual void startFlipping() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ViewFlipper)) 
				@__env.CallVoidMethod(this, _startFlipping10510); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ViewFlipper.staticClass, _startFlipping10510); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _stopFlipping10511; 
		public virtual void stopFlipping() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ViewFlipper)) 
				@__env.CallVoidMethod(this, _stopFlipping10511); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ViewFlipper.staticClass, _stopFlipping10511); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isFlipping10512; 
		public virtual bool isFlipping() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ViewFlipper)) 
				return @__env.CallBooleanMethod(this, _isFlipping10512); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.ViewFlipper.staticClass, _isFlipping10512); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setAutoStart10513; 
		public virtual void setAutoStart(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ViewFlipper)) 
				@__env.CallVoidMethod(this, _setAutoStart10513, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ViewFlipper.staticClass, _setAutoStart10513, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isAutoStart10514; 
		public virtual bool isAutoStart() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ViewFlipper)) 
				return @__env.CallBooleanMethod(this, _isAutoStart10514); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.ViewFlipper.staticClass, _isAutoStart10514); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ViewFlipper10515; 
		public ViewFlipper(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.ViewFlipper.staticClass, _ViewFlipper10515, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ViewFlipper10516; 
		public ViewFlipper(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.ViewFlipper.staticClass, _ViewFlipper10516, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.widget.ViewFlipper.staticClass = @__class; 
			global::android.widget.ViewFlipper._onAttachedToWindow10506 = @__env.GetMethodID(global::android.widget.ViewFlipper.staticClass, "onAttachedToWindow", "()V"); 
			global::android.widget.ViewFlipper._onDetachedFromWindow10507 = @__env.GetMethodID(global::android.widget.ViewFlipper.staticClass, "onDetachedFromWindow", "()V"); 
			global::android.widget.ViewFlipper._onWindowVisibilityChanged10508 = @__env.GetMethodID(global::android.widget.ViewFlipper.staticClass, "onWindowVisibilityChanged", "(I)V"); 
			global::android.widget.ViewFlipper._setFlipInterval10509 = @__env.GetMethodID(global::android.widget.ViewFlipper.staticClass, "setFlipInterval", "(I)V"); 
			global::android.widget.ViewFlipper._startFlipping10510 = @__env.GetMethodID(global::android.widget.ViewFlipper.staticClass, "startFlipping", "()V"); 
			global::android.widget.ViewFlipper._stopFlipping10511 = @__env.GetMethodID(global::android.widget.ViewFlipper.staticClass, "stopFlipping", "()V"); 
			global::android.widget.ViewFlipper._isFlipping10512 = @__env.GetMethodID(global::android.widget.ViewFlipper.staticClass, "isFlipping", "()Z"); 
			global::android.widget.ViewFlipper._setAutoStart10513 = @__env.GetMethodID(global::android.widget.ViewFlipper.staticClass, "setAutoStart", "(Z)V"); 
			global::android.widget.ViewFlipper._isAutoStart10514 = @__env.GetMethodID(global::android.widget.ViewFlipper.staticClass, "isAutoStart", "()Z"); 
			global::android.widget.ViewFlipper._ViewFlipper10515 = @__env.GetMethodID(global::android.widget.ViewFlipper.staticClass, "<init>", "(Landroid/content/Context;)V"); 
			global::android.widget.ViewFlipper._ViewFlipper10516 = @__env.GetMethodID(global::android.widget.ViewFlipper.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V"); 
		} 
	} 
} 
