namespace android.widget 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class RatingBar : android.widget.AbsSeekBar
	{ 
		internal new static global::java.lang.Class staticClass; 
		static RatingBar() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.widget.RatingBar), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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

		public partial class OnRatingBarChangeListener_ 
		{ 
			public static global::java.lang.Class _class 
			{ 
				get { return __OnRatingBarChangeListener.staticClass; } 
			} 
		} 

		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public sealed class __OnRatingBarChangeListener : java.lang.Object, OnRatingBarChangeListener
		{ 
			internal static global::java.lang.Class staticClass; 
			static __OnRatingBarChangeListener() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.widget.RatingBar.__OnRatingBarChangeListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.widget.RatingBar.__OnRatingBarChangeListener(@__env); 
				} 
			} 
			internal __OnRatingBarChangeListener(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _onRatingChanged10646; 
			 void android.widget.RatingBar.OnRatingBarChangeListener.onRatingChanged(android.widget.RatingBar arg0, float arg1, bool arg2) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (!IsClrObject) 
					@__env.CallVoidMethod(this, global::android.widget.RatingBar.__OnRatingBarChangeListener._onRatingChanged10646, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, global::android.widget.RatingBar.__OnRatingBarChangeListener.staticClass, global::android.widget.RatingBar.__OnRatingBarChangeListener._onRatingChanged10646, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.widget.RatingBar.__OnRatingBarChangeListener.staticClass = @__class; 
				global::android.widget.RatingBar.__OnRatingBarChangeListener._onRatingChanged10646 = @__env.GetMethodID(global::android.widget.RatingBar.__OnRatingBarChangeListener.staticClass, "android.widget.RatingBar.OnRatingBarChangeListener.onRatingChanged", "(Landroid/widget/RatingBar;FZ)V"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isIndicator10647; 
		public virtual bool isIndicator() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.widget.RatingBar._isIndicator10647); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.RatingBar.staticClass, global::android.widget.RatingBar._isIndicator10647); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onMeasure10648; 
		protected override void onMeasure(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.RatingBar._onMeasure10648, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.RatingBar.staticClass, global::android.widget.RatingBar._onMeasure10648, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setMax10649; 
		public override void setMax(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.RatingBar._setMax10649, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.RatingBar.staticClass, global::android.widget.RatingBar._setMax10649, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setOnRatingBarChangeListener10650; 
		public virtual void setOnRatingBarChangeListener(android.widget.RatingBar.OnRatingBarChangeListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.RatingBar._setOnRatingBarChangeListener10650, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.RatingBar.staticClass, global::android.widget.RatingBar._setOnRatingBarChangeListener10650, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getOnRatingBarChangeListener10651; 
		public virtual global::android.widget.RatingBar.OnRatingBarChangeListener getOnRatingBarChangeListener() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.RatingBar.OnRatingBarChangeListener>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.RatingBar._getOnRatingBarChangeListener10651)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.RatingBar.OnRatingBarChangeListener>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.RatingBar.staticClass, global::android.widget.RatingBar._getOnRatingBarChangeListener10651)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setIsIndicator10652; 
		public virtual void setIsIndicator(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.RatingBar._setIsIndicator10652, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.RatingBar.staticClass, global::android.widget.RatingBar._setIsIndicator10652, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setNumStars10653; 
		public virtual void setNumStars(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.RatingBar._setNumStars10653, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.RatingBar.staticClass, global::android.widget.RatingBar._setNumStars10653, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getNumStars10654; 
		public virtual int getNumStars() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.widget.RatingBar._getNumStars10654); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.RatingBar.staticClass, global::android.widget.RatingBar._getNumStars10654); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setRating10655; 
		public virtual void setRating(float arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.RatingBar._setRating10655, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.RatingBar.staticClass, global::android.widget.RatingBar._setRating10655, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getRating10656; 
		public virtual float getRating() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallFloatMethod(this, global::android.widget.RatingBar._getRating10656); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, global::android.widget.RatingBar.staticClass, global::android.widget.RatingBar._getRating10656); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setStepSize10657; 
		public virtual void setStepSize(float arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.RatingBar._setStepSize10657, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.RatingBar.staticClass, global::android.widget.RatingBar._setStepSize10657, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getStepSize10658; 
		public virtual float getStepSize() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallFloatMethod(this, global::android.widget.RatingBar._getStepSize10658); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, global::android.widget.RatingBar.staticClass, global::android.widget.RatingBar._getStepSize10658); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _RatingBar10659; 
		public RatingBar(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.RatingBar.staticClass, global::android.widget.RatingBar._RatingBar10659, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _RatingBar10660; 
		public RatingBar(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.RatingBar.staticClass, global::android.widget.RatingBar._RatingBar10660, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _RatingBar10661; 
		public RatingBar(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.RatingBar.staticClass, global::android.widget.RatingBar._RatingBar10661, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.widget.RatingBar.staticClass = @__class; 
			global::android.widget.RatingBar._isIndicator10647 = @__env.GetMethodID(global::android.widget.RatingBar.staticClass, "isIndicator", "()Z"); 
			global::android.widget.RatingBar._onMeasure10648 = @__env.GetMethodID(global::android.widget.RatingBar.staticClass, "onMeasure", "(II)V"); 
			global::android.widget.RatingBar._setMax10649 = @__env.GetMethodID(global::android.widget.RatingBar.staticClass, "setMax", "(I)V"); 
			global::android.widget.RatingBar._setOnRatingBarChangeListener10650 = @__env.GetMethodID(global::android.widget.RatingBar.staticClass, "setOnRatingBarChangeListener", "(Landroid/widget/RatingBar$OnRatingBarChangeListener;)V"); 
			global::android.widget.RatingBar._getOnRatingBarChangeListener10651 = @__env.GetMethodID(global::android.widget.RatingBar.staticClass, "getOnRatingBarChangeListener", "()Landroid/widget/RatingBar$OnRatingBarChangeListener;"); 
			global::android.widget.RatingBar._setIsIndicator10652 = @__env.GetMethodID(global::android.widget.RatingBar.staticClass, "setIsIndicator", "(Z)V"); 
			global::android.widget.RatingBar._setNumStars10653 = @__env.GetMethodID(global::android.widget.RatingBar.staticClass, "setNumStars", "(I)V"); 
			global::android.widget.RatingBar._getNumStars10654 = @__env.GetMethodID(global::android.widget.RatingBar.staticClass, "getNumStars", "()I"); 
			global::android.widget.RatingBar._setRating10655 = @__env.GetMethodID(global::android.widget.RatingBar.staticClass, "setRating", "(F)V"); 
			global::android.widget.RatingBar._getRating10656 = @__env.GetMethodID(global::android.widget.RatingBar.staticClass, "getRating", "()F"); 
			global::android.widget.RatingBar._setStepSize10657 = @__env.GetMethodID(global::android.widget.RatingBar.staticClass, "setStepSize", "(F)V"); 
			global::android.widget.RatingBar._getStepSize10658 = @__env.GetMethodID(global::android.widget.RatingBar.staticClass, "getStepSize", "()F"); 
			global::android.widget.RatingBar._RatingBar10659 = @__env.GetMethodID(global::android.widget.RatingBar.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V"); 
			global::android.widget.RatingBar._RatingBar10660 = @__env.GetMethodID(global::android.widget.RatingBar.staticClass, "<init>", "(Landroid/content/Context;)V"); 
			global::android.widget.RatingBar._RatingBar10661 = @__env.GetMethodID(global::android.widget.RatingBar.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V"); 
		} 
	} 
} 
