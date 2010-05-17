namespace android.widget 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class RatingBar : android.widget.AbsSeekBar
	{ 
		internal new static global::java.lang.Class staticClass; 
		static RatingBar() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.widget.RatingBar), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.widget.RatingBar(@__env); 
			} 
		} 
		protected RatingBar(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface OnRatingBarChangeListener 
		{ 
			void onRatingChanged(android.widget.RatingBar arg0, float arg1, bool arg2); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isIndicator9875; 
		public virtual bool isIndicator() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.RatingBar)) 
				return @__env.CallBooleanMethod(this, _isIndicator9875); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.RatingBar.staticClass, _isIndicator9875); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onMeasure9876; 
		protected override void onMeasure(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.RatingBar)) 
				@__env.CallVoidMethod(this, _onMeasure9876, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.RatingBar.staticClass, _onMeasure9876, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setMax9877; 
		public override void setMax(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.RatingBar)) 
				@__env.CallVoidMethod(this, _setMax9877, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.RatingBar.staticClass, _setMax9877, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setOnRatingBarChangeListener9878; 
		public virtual void setOnRatingBarChangeListener(android.widget.RatingBar.OnRatingBarChangeListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.RatingBar)) 
				@__env.CallVoidMethod(this, _setOnRatingBarChangeListener9878, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.RatingBar.staticClass, _setOnRatingBarChangeListener9878, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getOnRatingBarChangeListener9879; 
		public virtual android.widget.RatingBar.OnRatingBarChangeListener getOnRatingBarChangeListener() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.RatingBar)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.RatingBar.OnRatingBarChangeListener>(@__env, @__env.CallObjectMethodPtr(this, _getOnRatingBarChangeListener9879)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.RatingBar.OnRatingBarChangeListener>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.RatingBar.staticClass, _getOnRatingBarChangeListener9879)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setIsIndicator9880; 
		public virtual void setIsIndicator(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.RatingBar)) 
				@__env.CallVoidMethod(this, _setIsIndicator9880, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.RatingBar.staticClass, _setIsIndicator9880, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setNumStars9881; 
		public virtual void setNumStars(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.RatingBar)) 
				@__env.CallVoidMethod(this, _setNumStars9881, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.RatingBar.staticClass, _setNumStars9881, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getNumStars9882; 
		public virtual int getNumStars() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.RatingBar)) 
				return @__env.CallIntMethod(this, _getNumStars9882); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.RatingBar.staticClass, _getNumStars9882); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setRating9883; 
		public virtual void setRating(float arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.RatingBar)) 
				@__env.CallVoidMethod(this, _setRating9883, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.RatingBar.staticClass, _setRating9883, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getRating9884; 
		public virtual float getRating() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.RatingBar)) 
				return @__env.CallFloatMethod(this, _getRating9884); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, android.widget.RatingBar.staticClass, _getRating9884); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setStepSize9885; 
		public virtual void setStepSize(float arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.RatingBar)) 
				@__env.CallVoidMethod(this, _setStepSize9885, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.RatingBar.staticClass, _setStepSize9885, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getStepSize9886; 
		public virtual float getStepSize() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.RatingBar)) 
				return @__env.CallFloatMethod(this, _getStepSize9886); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, android.widget.RatingBar.staticClass, _getStepSize9886); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _RatingBar9887; 
		public RatingBar(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.RatingBar.staticClass, _RatingBar9887, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _RatingBar9888; 
		public RatingBar(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.RatingBar.staticClass, _RatingBar9888, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _RatingBar9889; 
		public RatingBar(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.RatingBar.staticClass, _RatingBar9889, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.widget.RatingBar.staticClass = @__class; 
			global::android.widget.RatingBar._isIndicator9875 = @__env.GetMethodID(global::android.widget.RatingBar.staticClass, "isIndicator", "()Z"); 
			global::android.widget.RatingBar._onMeasure9876 = @__env.GetMethodID(global::android.widget.RatingBar.staticClass, "onMeasure", "(II)V"); 
			global::android.widget.RatingBar._setMax9877 = @__env.GetMethodID(global::android.widget.RatingBar.staticClass, "setMax", "(I)V"); 
			global::android.widget.RatingBar._setOnRatingBarChangeListener9878 = @__env.GetMethodID(global::android.widget.RatingBar.staticClass, "setOnRatingBarChangeListener", "(Landroid/widget/RatingBar$OnRatingBarChangeListener;)V"); 
			global::android.widget.RatingBar._getOnRatingBarChangeListener9879 = @__env.GetMethodID(global::android.widget.RatingBar.staticClass, "getOnRatingBarChangeListener", "()Landroid/widget/RatingBar$OnRatingBarChangeListener;"); 
			global::android.widget.RatingBar._setIsIndicator9880 = @__env.GetMethodID(global::android.widget.RatingBar.staticClass, "setIsIndicator", "(Z)V"); 
			global::android.widget.RatingBar._setNumStars9881 = @__env.GetMethodID(global::android.widget.RatingBar.staticClass, "setNumStars", "(I)V"); 
			global::android.widget.RatingBar._getNumStars9882 = @__env.GetMethodID(global::android.widget.RatingBar.staticClass, "getNumStars", "()I"); 
			global::android.widget.RatingBar._setRating9883 = @__env.GetMethodID(global::android.widget.RatingBar.staticClass, "setRating", "(F)V"); 
			global::android.widget.RatingBar._getRating9884 = @__env.GetMethodID(global::android.widget.RatingBar.staticClass, "getRating", "()F"); 
			global::android.widget.RatingBar._setStepSize9885 = @__env.GetMethodID(global::android.widget.RatingBar.staticClass, "setStepSize", "(F)V"); 
			global::android.widget.RatingBar._getStepSize9886 = @__env.GetMethodID(global::android.widget.RatingBar.staticClass, "getStepSize", "()F"); 
			global::android.widget.RatingBar._RatingBar9887 = @__env.GetMethodID(global::android.widget.RatingBar.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V"); 
			global::android.widget.RatingBar._RatingBar9888 = @__env.GetMethodID(global::android.widget.RatingBar.staticClass, "<init>", "(Landroid/content/Context;)V"); 
			global::android.widget.RatingBar._RatingBar9889 = @__env.GetMethodID(global::android.widget.RatingBar.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V"); 
		} 
	} 
} 
