namespace android.view.animation
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public abstract class Animation : java.lang.Object, java.lang.Cloneable
	{
		internal static global::java.lang.Class staticClass;
		static Animation()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.view.animation.Animation), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		protected Animation(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
		public interface AnimationListener 
		{
			void onAnimationStart(android.view.animation.Animation arg0);
			void onAnimationEnd(android.view.animation.Animation arg0);
			void onAnimationRepeat(android.view.animation.Animation arg0);
		}

		public partial class AnimationListener_
		{
			public static global::java.lang.Class _class
			{
				get { return __AnimationListener.staticClass; }
			}
		}

		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public sealed class __AnimationListener : java.lang.Object, AnimationListener
		{
			internal static global::java.lang.Class staticClass;
			static __AnimationListener()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.view.animation.Animation.__AnimationListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.view.animation.Animation.__AnimationListener(@__env);
				}
			}
			internal __AnimationListener(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _onAnimationStart9553;
			 void android.view.animation.Animation.AnimationListener.onAnimationStart(android.view.animation.Animation arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.view.animation.Animation.__AnimationListener._onAnimationStart9553, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.view.animation.Animation.__AnimationListener.staticClass, global::android.view.animation.Animation.__AnimationListener._onAnimationStart9553, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _onAnimationEnd9554;
			 void android.view.animation.Animation.AnimationListener.onAnimationEnd(android.view.animation.Animation arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.view.animation.Animation.__AnimationListener._onAnimationEnd9554, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.view.animation.Animation.__AnimationListener.staticClass, global::android.view.animation.Animation.__AnimationListener._onAnimationEnd9554, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _onAnimationRepeat9555;
			 void android.view.animation.Animation.AnimationListener.onAnimationRepeat(android.view.animation.Animation arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.view.animation.Animation.__AnimationListener._onAnimationRepeat9555, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.view.animation.Animation.__AnimationListener.staticClass, global::android.view.animation.Animation.__AnimationListener._onAnimationRepeat9555, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.view.animation.Animation.__AnimationListener.staticClass = @__class;
				global::android.view.animation.Animation.__AnimationListener._onAnimationStart9553 = @__env.GetMethodID(global::android.view.animation.Animation.__AnimationListener.staticClass, "android.view.animation.Animation.AnimationListener.onAnimationStart", "(Landroid/view/animation/Animation;)V");
				global::android.view.animation.Animation.__AnimationListener._onAnimationEnd9554 = @__env.GetMethodID(global::android.view.animation.Animation.__AnimationListener.staticClass, "android.view.animation.Animation.AnimationListener.onAnimationEnd", "(Landroid/view/animation/Animation;)V");
				global::android.view.animation.Animation.__AnimationListener._onAnimationRepeat9555 = @__env.GetMethodID(global::android.view.animation.Animation.__AnimationListener.staticClass, "android.view.animation.Animation.AnimationListener.onAnimationRepeat", "(Landroid/view/animation/Animation;)V");
			}
		}
		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		protected class Description : java.lang.Object
		{
			internal static global::java.lang.Class staticClass;
			static Description()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.view.animation.Animation.Description), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.view.animation.Animation.Description(@__env);
				}
			}
			protected Description(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _Description9556;
			protected Description()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.view.animation.Animation.Description.staticClass, global::android.view.animation.Animation.Description._Description9556, this);
			}
			internal static global::net.sf.jni4net.jni.FieldId _type9557;
			public int type
			{
				get
				{
					return default(int);
				}
				set
				{
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _value9558;
			public float value
			{
				get
				{
					return default(float);
				}
				set
				{
				}
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.view.animation.Animation.Description.staticClass = @__class;
				global::android.view.animation.Animation.Description._Description9556 = @__env.GetMethodID(global::android.view.animation.Animation.Description.staticClass, "<init>", "()V");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _clone9559;
		protected virtual global::android.view.animation.Animation clone() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.animation.Animation>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.animation.Animation._clone9559));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.animation.Animation>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._clone9559));
		}
		internal static global::net.sf.jni4net.jni.MethodId _start9560;
		public virtual void start() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.animation.Animation._start9560);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._start9560);
		}
		internal static global::net.sf.jni4net.jni.MethodId _reset9561;
		public virtual void reset() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.animation.Animation._reset9561);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._reset9561);
		}
		internal static global::net.sf.jni4net.jni.MethodId _initialize9562;
		public virtual void initialize(int arg0, int arg1, int arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.animation.Animation._initialize9562, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._initialize9562, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _cancel9563;
		public virtual void cancel() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.animation.Animation._cancel9563);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._cancel9563);
		}
		internal static global::net.sf.jni4net.jni.MethodId _resolveSize9564;
		protected virtual float resolveSize(int arg0, float arg1, int arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.view.animation.Animation._resolveSize9564, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._resolveSize9564, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getRepeatCount9565;
		public virtual int getRepeatCount() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.view.animation.Animation._getRepeatCount9565);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._getRepeatCount9565);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setInterpolator9566;
		public virtual void setInterpolator(android.view.animation.Interpolator arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.animation.Animation._setInterpolator9566, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._setInterpolator9566, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setInterpolator9567;
		public virtual void setInterpolator(android.content.Context arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.animation.Animation._setInterpolator9567, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._setInterpolator9567, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getInterpolator9568;
		public virtual global::android.view.animation.Interpolator getInterpolator() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.animation.Interpolator>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.animation.Animation._getInterpolator9568));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.animation.Interpolator>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._getInterpolator9568));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isInitialized9569;
		public virtual bool isInitialized() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.animation.Animation._isInitialized9569);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._isInitialized9569);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setStartOffset9570;
		public virtual void setStartOffset(long arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.animation.Animation._setStartOffset9570, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._setStartOffset9570, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setDuration9571;
		public virtual void setDuration(long arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.animation.Animation._setDuration9571, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._setDuration9571, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _restrictDuration9572;
		public virtual void restrictDuration(long arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.animation.Animation._restrictDuration9572, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._restrictDuration9572, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _scaleCurrentDuration9573;
		public virtual void scaleCurrentDuration(float arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.animation.Animation._scaleCurrentDuration9573, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._scaleCurrentDuration9573, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setStartTime9574;
		public virtual void setStartTime(long arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.animation.Animation._setStartTime9574, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._setStartTime9574, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _startNow9575;
		public virtual void startNow() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.animation.Animation._startNow9575);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._startNow9575);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setRepeatMode9576;
		public virtual void setRepeatMode(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.animation.Animation._setRepeatMode9576, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._setRepeatMode9576, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setRepeatCount9577;
		public virtual void setRepeatCount(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.animation.Animation._setRepeatCount9577, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._setRepeatCount9577, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isFillEnabled9578;
		public virtual bool isFillEnabled() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.animation.Animation._isFillEnabled9578);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._isFillEnabled9578);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setFillEnabled9579;
		public virtual void setFillEnabled(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.animation.Animation._setFillEnabled9579, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._setFillEnabled9579, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setFillBefore9580;
		public virtual void setFillBefore(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.animation.Animation._setFillBefore9580, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._setFillBefore9580, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setFillAfter9581;
		public virtual void setFillAfter(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.animation.Animation._setFillAfter9581, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._setFillAfter9581, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setZAdjustment9582;
		public virtual void setZAdjustment(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.animation.Animation._setZAdjustment9582, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._setZAdjustment9582, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setDetachWallpaper9583;
		public virtual void setDetachWallpaper(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.animation.Animation._setDetachWallpaper9583, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._setDetachWallpaper9583, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getStartTime9584;
		public virtual long getStartTime() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this, global::android.view.animation.Animation._getStartTime9584);
			else
				return @__env.CallNonVirtualLongMethod(this, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._getStartTime9584);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDuration9585;
		public virtual long getDuration() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this, global::android.view.animation.Animation._getDuration9585);
			else
				return @__env.CallNonVirtualLongMethod(this, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._getDuration9585);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getStartOffset9586;
		public virtual long getStartOffset() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this, global::android.view.animation.Animation._getStartOffset9586);
			else
				return @__env.CallNonVirtualLongMethod(this, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._getStartOffset9586);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getRepeatMode9587;
		public virtual int getRepeatMode() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.view.animation.Animation._getRepeatMode9587);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._getRepeatMode9587);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getFillBefore9588;
		public virtual bool getFillBefore() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.animation.Animation._getFillBefore9588);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._getFillBefore9588);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getFillAfter9589;
		public virtual bool getFillAfter() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.animation.Animation._getFillAfter9589);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._getFillAfter9589);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getZAdjustment9590;
		public virtual int getZAdjustment() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.view.animation.Animation._getZAdjustment9590);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._getZAdjustment9590);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDetachWallpaper9591;
		public virtual bool getDetachWallpaper() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.animation.Animation._getDetachWallpaper9591);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._getDetachWallpaper9591);
		}
		internal static global::net.sf.jni4net.jni.MethodId _willChangeTransformationMatrix9592;
		public virtual bool willChangeTransformationMatrix() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.animation.Animation._willChangeTransformationMatrix9592);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._willChangeTransformationMatrix9592);
		}
		internal static global::net.sf.jni4net.jni.MethodId _willChangeBounds9593;
		public virtual bool willChangeBounds() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.animation.Animation._willChangeBounds9593);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._willChangeBounds9593);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setAnimationListener9594;
		public virtual void setAnimationListener(android.view.animation.Animation.AnimationListener arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.animation.Animation._setAnimationListener9594, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._setAnimationListener9594, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _ensureInterpolator9595;
		protected virtual void ensureInterpolator() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.animation.Animation._ensureInterpolator9595);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._ensureInterpolator9595);
		}
		internal static global::net.sf.jni4net.jni.MethodId _computeDurationHint9596;
		public virtual long computeDurationHint() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this, global::android.view.animation.Animation._computeDurationHint9596);
			else
				return @__env.CallNonVirtualLongMethod(this, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._computeDurationHint9596);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getTransformation9597;
		public virtual bool getTransformation(long arg0, android.view.animation.Transformation arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.animation.Animation._getTransformation9597, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._getTransformation9597, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _hasStarted9598;
		public virtual bool hasStarted() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.animation.Animation._hasStarted9598);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._hasStarted9598);
		}
		internal static global::net.sf.jni4net.jni.MethodId _hasEnded9599;
		public virtual bool hasEnded() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.animation.Animation._hasEnded9599);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._hasEnded9599);
		}
		internal static global::net.sf.jni4net.jni.MethodId _applyTransformation9600;
		protected virtual void applyTransformation(float arg0, android.view.animation.Transformation arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.animation.Animation._applyTransformation9600, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._applyTransformation9600, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Animation9601;
		public Animation(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.view.animation.Animation.staticClass, global::android.view.animation.Animation._Animation9601, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Animation9602;
		public Animation()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.view.animation.Animation.staticClass, global::android.view.animation.Animation._Animation9602, this);
		}
		public static int INFINITE
		{
			get
			{
				return -1;
			}
		}
		public static int RESTART
		{
			get
			{
				return 1;
			}
		}
		public static int REVERSE
		{
			get
			{
				return 2;
			}
		}
		public static int START_ON_FIRST_FRAME
		{
			get
			{
				return -1;
			}
		}
		public static int ABSOLUTE
		{
			get
			{
				return 0;
			}
		}
		public static int RELATIVE_TO_SELF
		{
			get
			{
				return 1;
			}
		}
		public static int RELATIVE_TO_PARENT
		{
			get
			{
				return 2;
			}
		}
		public static int ZORDER_NORMAL
		{
			get
			{
				return 0;
			}
		}
		public static int ZORDER_TOP
		{
			get
			{
				return 1;
			}
		}
		public static int ZORDER_BOTTOM
		{
			get
			{
				return -1;
			}
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.view.animation.Animation.staticClass = @__class;
			global::android.view.animation.Animation._clone9559 = @__env.GetMethodID(global::android.view.animation.Animation.staticClass, "clone", "()Landroid/view/animation/Animation;");
			global::android.view.animation.Animation._start9560 = @__env.GetMethodID(global::android.view.animation.Animation.staticClass, "start", "()V");
			global::android.view.animation.Animation._reset9561 = @__env.GetMethodID(global::android.view.animation.Animation.staticClass, "reset", "()V");
			global::android.view.animation.Animation._initialize9562 = @__env.GetMethodID(global::android.view.animation.Animation.staticClass, "initialize", "(IIII)V");
			global::android.view.animation.Animation._cancel9563 = @__env.GetMethodID(global::android.view.animation.Animation.staticClass, "cancel", "()V");
			global::android.view.animation.Animation._resolveSize9564 = @__env.GetMethodID(global::android.view.animation.Animation.staticClass, "resolveSize", "(IFII)F");
			global::android.view.animation.Animation._getRepeatCount9565 = @__env.GetMethodID(global::android.view.animation.Animation.staticClass, "getRepeatCount", "()I");
			global::android.view.animation.Animation._setInterpolator9566 = @__env.GetMethodID(global::android.view.animation.Animation.staticClass, "setInterpolator", "(Landroid/view/animation/Interpolator;)V");
			global::android.view.animation.Animation._setInterpolator9567 = @__env.GetMethodID(global::android.view.animation.Animation.staticClass, "setInterpolator", "(Landroid/content/Context;I)V");
			global::android.view.animation.Animation._getInterpolator9568 = @__env.GetMethodID(global::android.view.animation.Animation.staticClass, "getInterpolator", "()Landroid/view/animation/Interpolator;");
			global::android.view.animation.Animation._isInitialized9569 = @__env.GetMethodID(global::android.view.animation.Animation.staticClass, "isInitialized", "()Z");
			global::android.view.animation.Animation._setStartOffset9570 = @__env.GetMethodID(global::android.view.animation.Animation.staticClass, "setStartOffset", "(J)V");
			global::android.view.animation.Animation._setDuration9571 = @__env.GetMethodID(global::android.view.animation.Animation.staticClass, "setDuration", "(J)V");
			global::android.view.animation.Animation._restrictDuration9572 = @__env.GetMethodID(global::android.view.animation.Animation.staticClass, "restrictDuration", "(J)V");
			global::android.view.animation.Animation._scaleCurrentDuration9573 = @__env.GetMethodID(global::android.view.animation.Animation.staticClass, "scaleCurrentDuration", "(F)V");
			global::android.view.animation.Animation._setStartTime9574 = @__env.GetMethodID(global::android.view.animation.Animation.staticClass, "setStartTime", "(J)V");
			global::android.view.animation.Animation._startNow9575 = @__env.GetMethodID(global::android.view.animation.Animation.staticClass, "startNow", "()V");
			global::android.view.animation.Animation._setRepeatMode9576 = @__env.GetMethodID(global::android.view.animation.Animation.staticClass, "setRepeatMode", "(I)V");
			global::android.view.animation.Animation._setRepeatCount9577 = @__env.GetMethodID(global::android.view.animation.Animation.staticClass, "setRepeatCount", "(I)V");
			global::android.view.animation.Animation._isFillEnabled9578 = @__env.GetMethodID(global::android.view.animation.Animation.staticClass, "isFillEnabled", "()Z");
			global::android.view.animation.Animation._setFillEnabled9579 = @__env.GetMethodID(global::android.view.animation.Animation.staticClass, "setFillEnabled", "(Z)V");
			global::android.view.animation.Animation._setFillBefore9580 = @__env.GetMethodID(global::android.view.animation.Animation.staticClass, "setFillBefore", "(Z)V");
			global::android.view.animation.Animation._setFillAfter9581 = @__env.GetMethodID(global::android.view.animation.Animation.staticClass, "setFillAfter", "(Z)V");
			global::android.view.animation.Animation._setZAdjustment9582 = @__env.GetMethodID(global::android.view.animation.Animation.staticClass, "setZAdjustment", "(I)V");
			global::android.view.animation.Animation._setDetachWallpaper9583 = @__env.GetMethodID(global::android.view.animation.Animation.staticClass, "setDetachWallpaper", "(Z)V");
			global::android.view.animation.Animation._getStartTime9584 = @__env.GetMethodID(global::android.view.animation.Animation.staticClass, "getStartTime", "()J");
			global::android.view.animation.Animation._getDuration9585 = @__env.GetMethodID(global::android.view.animation.Animation.staticClass, "getDuration", "()J");
			global::android.view.animation.Animation._getStartOffset9586 = @__env.GetMethodID(global::android.view.animation.Animation.staticClass, "getStartOffset", "()J");
			global::android.view.animation.Animation._getRepeatMode9587 = @__env.GetMethodID(global::android.view.animation.Animation.staticClass, "getRepeatMode", "()I");
			global::android.view.animation.Animation._getFillBefore9588 = @__env.GetMethodID(global::android.view.animation.Animation.staticClass, "getFillBefore", "()Z");
			global::android.view.animation.Animation._getFillAfter9589 = @__env.GetMethodID(global::android.view.animation.Animation.staticClass, "getFillAfter", "()Z");
			global::android.view.animation.Animation._getZAdjustment9590 = @__env.GetMethodID(global::android.view.animation.Animation.staticClass, "getZAdjustment", "()I");
			global::android.view.animation.Animation._getDetachWallpaper9591 = @__env.GetMethodID(global::android.view.animation.Animation.staticClass, "getDetachWallpaper", "()Z");
			global::android.view.animation.Animation._willChangeTransformationMatrix9592 = @__env.GetMethodID(global::android.view.animation.Animation.staticClass, "willChangeTransformationMatrix", "()Z");
			global::android.view.animation.Animation._willChangeBounds9593 = @__env.GetMethodID(global::android.view.animation.Animation.staticClass, "willChangeBounds", "()Z");
			global::android.view.animation.Animation._setAnimationListener9594 = @__env.GetMethodID(global::android.view.animation.Animation.staticClass, "setAnimationListener", "(Landroid/view/animation/Animation$AnimationListener;)V");
			global::android.view.animation.Animation._ensureInterpolator9595 = @__env.GetMethodID(global::android.view.animation.Animation.staticClass, "ensureInterpolator", "()V");
			global::android.view.animation.Animation._computeDurationHint9596 = @__env.GetMethodID(global::android.view.animation.Animation.staticClass, "computeDurationHint", "()J");
			global::android.view.animation.Animation._getTransformation9597 = @__env.GetMethodID(global::android.view.animation.Animation.staticClass, "getTransformation", "(JLandroid/view/animation/Transformation;)Z");
			global::android.view.animation.Animation._hasStarted9598 = @__env.GetMethodID(global::android.view.animation.Animation.staticClass, "hasStarted", "()Z");
			global::android.view.animation.Animation._hasEnded9599 = @__env.GetMethodID(global::android.view.animation.Animation.staticClass, "hasEnded", "()Z");
			global::android.view.animation.Animation._applyTransformation9600 = @__env.GetMethodID(global::android.view.animation.Animation.staticClass, "applyTransformation", "(FLandroid/view/animation/Transformation;)V");
			global::android.view.animation.Animation._Animation9601 = @__env.GetMethodID(global::android.view.animation.Animation.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.view.animation.Animation._Animation9602 = @__env.GetMethodID(global::android.view.animation.Animation.staticClass, "<init>", "()V");
		}
	}
}
