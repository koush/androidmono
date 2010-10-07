namespace android.graphics.drawable
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public abstract class Drawable : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static Drawable()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.graphics.drawable.Drawable), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		protected Drawable(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
		public interface Callback 
		{
			void invalidateDrawable(android.graphics.drawable.Drawable arg0);
			void scheduleDrawable(android.graphics.drawable.Drawable arg0, java.lang.Runnable arg1, long arg2);
			void unscheduleDrawable(android.graphics.drawable.Drawable arg0, java.lang.Runnable arg1);
		}

		public partial class Callback_
		{
			public static global::java.lang.Class _class
			{
				get { return __Callback.staticClass; }
			}
		}

		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public sealed class __Callback : java.lang.Object, Callback
		{
			internal static global::java.lang.Class staticClass;
			static __Callback()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.graphics.drawable.Drawable.__Callback), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.graphics.drawable.Drawable.__Callback(@__env);
				}
			}
			internal __Callback(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _invalidateDrawable3719;
			 void android.graphics.drawable.Drawable.Callback.invalidateDrawable(android.graphics.drawable.Drawable arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.graphics.drawable.Drawable.__Callback._invalidateDrawable3719, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.Drawable.__Callback.staticClass, global::android.graphics.drawable.Drawable.__Callback._invalidateDrawable3719, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _scheduleDrawable3720;
			 void android.graphics.drawable.Drawable.Callback.scheduleDrawable(android.graphics.drawable.Drawable arg0, java.lang.Runnable arg1, long arg2) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.graphics.drawable.Drawable.__Callback._scheduleDrawable3720, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.Drawable.__Callback.staticClass, global::android.graphics.drawable.Drawable.__Callback._scheduleDrawable3720, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			}
			internal static global::net.sf.jni4net.jni.MethodId _unscheduleDrawable3721;
			 void android.graphics.drawable.Drawable.Callback.unscheduleDrawable(android.graphics.drawable.Drawable arg0, java.lang.Runnable arg1) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.graphics.drawable.Drawable.__Callback._unscheduleDrawable3721, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.Drawable.__Callback.staticClass, global::android.graphics.drawable.Drawable.__Callback._unscheduleDrawable3721, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.graphics.drawable.Drawable.__Callback.staticClass = @__class;
				global::android.graphics.drawable.Drawable.__Callback._invalidateDrawable3719 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.__Callback.staticClass, "android.graphics.drawable.Drawable.Callback.invalidateDrawable", "(Landroid/graphics/drawable/Drawable;)V");
				global::android.graphics.drawable.Drawable.__Callback._scheduleDrawable3720 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.__Callback.staticClass, "android.graphics.drawable.Drawable.Callback.scheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;J)V");
				global::android.graphics.drawable.Drawable.__Callback._unscheduleDrawable3721 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.__Callback.staticClass, "android.graphics.drawable.Drawable.Callback.unscheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;)V");
			}
		}
		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public abstract class ConstantState : java.lang.Object
		{
			internal static global::java.lang.Class staticClass;
			static ConstantState()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.graphics.drawable.Drawable.ConstantState), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			protected ConstantState(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _getChangingConfigurations3722;
			public abstract int getChangingConfigurations();
			internal static global::net.sf.jni4net.jni.MethodId _newDrawable3723;
			public abstract global::android.graphics.drawable.Drawable newDrawable();
			internal static global::net.sf.jni4net.jni.MethodId _newDrawable3724;
			public virtual global::android.graphics.drawable.Drawable newDrawable(android.content.res.Resources arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.drawable.Drawable.ConstantState._newDrawable3724, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.drawable.Drawable.ConstantState.staticClass, global::android.graphics.drawable.Drawable.ConstantState._newDrawable3724, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			}
			internal static global::net.sf.jni4net.jni.MethodId _ConstantState3725;
			public ConstantState()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.graphics.drawable.Drawable.ConstantState.staticClass, global::android.graphics.drawable.Drawable.ConstantState._ConstantState3725, this);
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.graphics.drawable.Drawable.ConstantState.staticClass = @__class;
				global::android.graphics.drawable.Drawable.ConstantState._getChangingConfigurations3722 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.ConstantState.staticClass, "getChangingConfigurations", "()I");
				global::android.graphics.drawable.Drawable.ConstantState._newDrawable3723 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.ConstantState.staticClass, "newDrawable", "()Landroid/graphics/drawable/Drawable;");
				global::android.graphics.drawable.Drawable.ConstantState._newDrawable3724 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.ConstantState.staticClass, "newDrawable", "(Landroid/content/res/Resources;)Landroid/graphics/drawable/Drawable;");
				global::android.graphics.drawable.Drawable.ConstantState._ConstantState3725 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.ConstantState.staticClass, "<init>", "()V");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _getState3726;
		public virtual int[] getState() 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.drawable.Drawable._getState3726));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._getState3726));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setState3727;
		public virtual bool setState(int[] arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.drawable.Drawable._setState3727, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._setState3727, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _inflate3728;
		public virtual void inflate(android.content.res.Resources arg0, org.xmlpull.v1.XmlPullParser arg1, android.util.AttributeSet arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.Drawable._inflate3728, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._inflate3728, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _draw3729;
		public abstract void draw(android.graphics.Canvas arg0);
		internal static global::net.sf.jni4net.jni.MethodId _setBounds3730;
		public virtual void setBounds(int arg0, int arg1, int arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.Drawable._setBounds3730, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._setBounds3730, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setBounds3731;
		public virtual void setBounds(android.graphics.Rect arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.Drawable._setBounds3731, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._setBounds3731, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _copyBounds3732;
		public virtual void copyBounds(android.graphics.Rect arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.Drawable._copyBounds3732, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._copyBounds3732, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _copyBounds3733;
		public virtual global::android.graphics.Rect copyBounds() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Rect>(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.drawable.Drawable._copyBounds3733));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Rect>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._copyBounds3733));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getBounds3734;
		public virtual global::android.graphics.Rect getBounds() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Rect>(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.drawable.Drawable._getBounds3734));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Rect>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._getBounds3734));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setChangingConfigurations3735;
		public virtual void setChangingConfigurations(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.Drawable._setChangingConfigurations3735, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._setChangingConfigurations3735, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getChangingConfigurations3736;
		public virtual int getChangingConfigurations() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.graphics.drawable.Drawable._getChangingConfigurations3736);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._getChangingConfigurations3736);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setDither3737;
		public virtual void setDither(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.Drawable._setDither3737, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._setDither3737, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setFilterBitmap3738;
		public virtual void setFilterBitmap(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.Drawable._setFilterBitmap3738, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._setFilterBitmap3738, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setCallback3739;
		public virtual void setCallback(android.graphics.drawable.Drawable.Callback arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.Drawable._setCallback3739, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._setCallback3739, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _invalidateSelf3740;
		public virtual void invalidateSelf() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.Drawable._invalidateSelf3740);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._invalidateSelf3740);
		}
		internal static global::net.sf.jni4net.jni.MethodId _scheduleSelf3741;
		public virtual void scheduleSelf(java.lang.Runnable arg0, long arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.Drawable._scheduleSelf3741, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._scheduleSelf3741, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _unscheduleSelf3742;
		public virtual void unscheduleSelf(java.lang.Runnable arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.Drawable._unscheduleSelf3742, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._unscheduleSelf3742, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setAlpha3743;
		public abstract void setAlpha(int arg0);
		internal static global::net.sf.jni4net.jni.MethodId _setColorFilter3744;
		public abstract void setColorFilter(android.graphics.ColorFilter arg0);
		internal static global::net.sf.jni4net.jni.MethodId _setColorFilter3745;
		public virtual void setColorFilter(int arg0, android.graphics.PorterDuff.Mode arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.Drawable._setColorFilter3745, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._setColorFilter3745, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _clearColorFilter3746;
		public virtual void clearColorFilter() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.Drawable._clearColorFilter3746);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._clearColorFilter3746);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isStateful3747;
		public virtual bool isStateful() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.drawable.Drawable._isStateful3747);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._isStateful3747);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getCurrent3748;
		public virtual global::android.graphics.drawable.Drawable getCurrent() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.drawable.Drawable._getCurrent3748));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._getCurrent3748));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setLevel3749;
		public virtual bool setLevel(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.drawable.Drawable._setLevel3749, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._setLevel3749, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLevel3750;
		public virtual int getLevel() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.graphics.drawable.Drawable._getLevel3750);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._getLevel3750);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setVisible3751;
		public virtual bool setVisible(bool arg0, bool arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.drawable.Drawable._setVisible3751, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._setVisible3751, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isVisible3752;
		public virtual bool isVisible() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.drawable.Drawable._isVisible3752);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._isVisible3752);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getOpacity3753;
		public abstract int getOpacity();
		internal static global::net.sf.jni4net.jni.MethodId _resolveOpacity3754;
		public static int resolveOpacity(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._resolveOpacity3754, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getTransparentRegion3755;
		public virtual global::android.graphics.Region getTransparentRegion() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Region>(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.drawable.Drawable._getTransparentRegion3755));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Region>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._getTransparentRegion3755));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onStateChange3756;
		protected virtual bool onStateChange(int[] arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.drawable.Drawable._onStateChange3756, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._onStateChange3756, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onLevelChange3757;
		protected virtual bool onLevelChange(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.drawable.Drawable._onLevelChange3757, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._onLevelChange3757, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onBoundsChange3758;
		protected virtual void onBoundsChange(android.graphics.Rect arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.Drawable._onBoundsChange3758, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._onBoundsChange3758, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getIntrinsicWidth3759;
		public virtual int getIntrinsicWidth() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.graphics.drawable.Drawable._getIntrinsicWidth3759);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._getIntrinsicWidth3759);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getIntrinsicHeight3760;
		public virtual int getIntrinsicHeight() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.graphics.drawable.Drawable._getIntrinsicHeight3760);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._getIntrinsicHeight3760);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getMinimumWidth3761;
		public virtual int getMinimumWidth() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.graphics.drawable.Drawable._getMinimumWidth3761);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._getMinimumWidth3761);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getMinimumHeight3762;
		public virtual int getMinimumHeight() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.graphics.drawable.Drawable._getMinimumHeight3762);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._getMinimumHeight3762);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPadding3763;
		public virtual bool getPadding(android.graphics.Rect arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.drawable.Drawable._getPadding3763, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._getPadding3763, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _mutate3764;
		public virtual global::android.graphics.drawable.Drawable mutate() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.drawable.Drawable._mutate3764));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._mutate3764));
		}
		internal static global::net.sf.jni4net.jni.MethodId _createFromStream3765;
		public static global::android.graphics.drawable.Drawable createFromStream(java.io.InputStream arg0, java.lang.String arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._createFromStream3765, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _createFromResourceStream3766;
		public static global::android.graphics.drawable.Drawable createFromResourceStream(android.content.res.Resources arg0, android.util.TypedValue arg1, java.io.InputStream arg2, java.lang.String arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._createFromResourceStream3766, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _createFromResourceStream3767;
		public static global::android.graphics.drawable.Drawable createFromResourceStream(android.content.res.Resources arg0, android.util.TypedValue arg1, java.io.InputStream arg2, java.lang.String arg3, android.graphics.BitmapFactory.Options arg4) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._createFromResourceStream3767, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _createFromXml3768;
		public static global::android.graphics.drawable.Drawable createFromXml(android.content.res.Resources arg0, org.xmlpull.v1.XmlPullParser arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._createFromXml3768, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _createFromXmlInner3769;
		public static global::android.graphics.drawable.Drawable createFromXmlInner(android.content.res.Resources arg0, org.xmlpull.v1.XmlPullParser arg1, android.util.AttributeSet arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._createFromXmlInner3769, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _createFromPath3770;
		public static global::android.graphics.drawable.Drawable createFromPath(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._createFromPath3770, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getConstantState3771;
		public virtual global::android.graphics.drawable.Drawable.ConstantState getConstantState() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable.ConstantState>(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.drawable.Drawable._getConstantState3771));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable.ConstantState>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._getConstantState3771));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Drawable3772;
		public Drawable()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._Drawable3772, this);
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.graphics.drawable.Drawable.staticClass = @__class;
			global::android.graphics.drawable.Drawable._getState3726 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.staticClass, "getState", "()[I");
			global::android.graphics.drawable.Drawable._setState3727 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.staticClass, "setState", "([I)Z");
			global::android.graphics.drawable.Drawable._inflate3728 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.staticClass, "inflate", "(Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;Landroid/util/AttributeSet;)V");
			global::android.graphics.drawable.Drawable._draw3729 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.staticClass, "draw", "(Landroid/graphics/Canvas;)V");
			global::android.graphics.drawable.Drawable._setBounds3730 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.staticClass, "setBounds", "(IIII)V");
			global::android.graphics.drawable.Drawable._setBounds3731 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.staticClass, "setBounds", "(Landroid/graphics/Rect;)V");
			global::android.graphics.drawable.Drawable._copyBounds3732 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.staticClass, "copyBounds", "(Landroid/graphics/Rect;)V");
			global::android.graphics.drawable.Drawable._copyBounds3733 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.staticClass, "copyBounds", "()Landroid/graphics/Rect;");
			global::android.graphics.drawable.Drawable._getBounds3734 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.staticClass, "getBounds", "()Landroid/graphics/Rect;");
			global::android.graphics.drawable.Drawable._setChangingConfigurations3735 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.staticClass, "setChangingConfigurations", "(I)V");
			global::android.graphics.drawable.Drawable._getChangingConfigurations3736 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.staticClass, "getChangingConfigurations", "()I");
			global::android.graphics.drawable.Drawable._setDither3737 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.staticClass, "setDither", "(Z)V");
			global::android.graphics.drawable.Drawable._setFilterBitmap3738 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.staticClass, "setFilterBitmap", "(Z)V");
			global::android.graphics.drawable.Drawable._setCallback3739 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.staticClass, "setCallback", "(Landroid/graphics/drawable/Drawable$Callback;)V");
			global::android.graphics.drawable.Drawable._invalidateSelf3740 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.staticClass, "invalidateSelf", "()V");
			global::android.graphics.drawable.Drawable._scheduleSelf3741 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.staticClass, "scheduleSelf", "(Ljava/lang/Runnable;J)V");
			global::android.graphics.drawable.Drawable._unscheduleSelf3742 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.staticClass, "unscheduleSelf", "(Ljava/lang/Runnable;)V");
			global::android.graphics.drawable.Drawable._setAlpha3743 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.staticClass, "setAlpha", "(I)V");
			global::android.graphics.drawable.Drawable._setColorFilter3744 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.staticClass, "setColorFilter", "(Landroid/graphics/ColorFilter;)V");
			global::android.graphics.drawable.Drawable._setColorFilter3745 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.staticClass, "setColorFilter", "(ILandroid/graphics/PorterDuff$Mode;)V");
			global::android.graphics.drawable.Drawable._clearColorFilter3746 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.staticClass, "clearColorFilter", "()V");
			global::android.graphics.drawable.Drawable._isStateful3747 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.staticClass, "isStateful", "()Z");
			global::android.graphics.drawable.Drawable._getCurrent3748 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.staticClass, "getCurrent", "()Landroid/graphics/drawable/Drawable;");
			global::android.graphics.drawable.Drawable._setLevel3749 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.staticClass, "setLevel", "(I)Z");
			global::android.graphics.drawable.Drawable._getLevel3750 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.staticClass, "getLevel", "()I");
			global::android.graphics.drawable.Drawable._setVisible3751 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.staticClass, "setVisible", "(ZZ)Z");
			global::android.graphics.drawable.Drawable._isVisible3752 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.staticClass, "isVisible", "()Z");
			global::android.graphics.drawable.Drawable._getOpacity3753 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.staticClass, "getOpacity", "()I");
			global::android.graphics.drawable.Drawable._resolveOpacity3754 = @__env.GetStaticMethodID(global::android.graphics.drawable.Drawable.staticClass, "resolveOpacity", "(II)I");
			global::android.graphics.drawable.Drawable._getTransparentRegion3755 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.staticClass, "getTransparentRegion", "()Landroid/graphics/Region;");
			global::android.graphics.drawable.Drawable._onStateChange3756 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.staticClass, "onStateChange", "([I)Z");
			global::android.graphics.drawable.Drawable._onLevelChange3757 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.staticClass, "onLevelChange", "(I)Z");
			global::android.graphics.drawable.Drawable._onBoundsChange3758 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.staticClass, "onBoundsChange", "(Landroid/graphics/Rect;)V");
			global::android.graphics.drawable.Drawable._getIntrinsicWidth3759 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.staticClass, "getIntrinsicWidth", "()I");
			global::android.graphics.drawable.Drawable._getIntrinsicHeight3760 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.staticClass, "getIntrinsicHeight", "()I");
			global::android.graphics.drawable.Drawable._getMinimumWidth3761 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.staticClass, "getMinimumWidth", "()I");
			global::android.graphics.drawable.Drawable._getMinimumHeight3762 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.staticClass, "getMinimumHeight", "()I");
			global::android.graphics.drawable.Drawable._getPadding3763 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.staticClass, "getPadding", "(Landroid/graphics/Rect;)Z");
			global::android.graphics.drawable.Drawable._mutate3764 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.staticClass, "mutate", "()Landroid/graphics/drawable/Drawable;");
			global::android.graphics.drawable.Drawable._createFromStream3765 = @__env.GetStaticMethodID(global::android.graphics.drawable.Drawable.staticClass, "createFromStream", "(Ljava/io/InputStream;Ljava/lang/String;)Landroid/graphics/drawable/Drawable;");
			global::android.graphics.drawable.Drawable._createFromResourceStream3766 = @__env.GetStaticMethodID(global::android.graphics.drawable.Drawable.staticClass, "createFromResourceStream", "(Landroid/content/res/Resources;Landroid/util/TypedValue;Ljava/io/InputStream;Ljava/lang/String;)Landroid/graphics/drawable/Drawable;");
			global::android.graphics.drawable.Drawable._createFromResourceStream3767 = @__env.GetStaticMethodID(global::android.graphics.drawable.Drawable.staticClass, "createFromResourceStream", "(Landroid/content/res/Resources;Landroid/util/TypedValue;Ljava/io/InputStream;Ljava/lang/String;Landroid/graphics/BitmapFactory$Options;)Landroid/graphics/drawable/Drawable;");
			global::android.graphics.drawable.Drawable._createFromXml3768 = @__env.GetStaticMethodID(global::android.graphics.drawable.Drawable.staticClass, "createFromXml", "(Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;)Landroid/graphics/drawable/Drawable;");
			global::android.graphics.drawable.Drawable._createFromXmlInner3769 = @__env.GetStaticMethodID(global::android.graphics.drawable.Drawable.staticClass, "createFromXmlInner", "(Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;Landroid/util/AttributeSet;)Landroid/graphics/drawable/Drawable;");
			global::android.graphics.drawable.Drawable._createFromPath3770 = @__env.GetStaticMethodID(global::android.graphics.drawable.Drawable.staticClass, "createFromPath", "(Ljava/lang/String;)Landroid/graphics/drawable/Drawable;");
			global::android.graphics.drawable.Drawable._getConstantState3771 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.staticClass, "getConstantState", "()Landroid/graphics/drawable/Drawable$ConstantState;");
			global::android.graphics.drawable.Drawable._Drawable3772 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.staticClass, "<init>", "()V");
		}
	}
}
