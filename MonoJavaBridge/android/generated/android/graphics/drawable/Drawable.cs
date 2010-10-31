namespace android.graphics.drawable
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.graphics.drawable.Drawable_))]
	public abstract partial class Drawable : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Drawable(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.graphics.drawable.Drawable.Callback_))]
		public partial interface Callback  : global::MonoJavaBridge.IJavaObject 
		{
			void invalidateDrawable(android.graphics.drawable.Drawable arg0);
			void scheduleDrawable(android.graphics.drawable.Drawable arg0, java.lang.Runnable arg1, long arg2);
			void unscheduleDrawable(android.graphics.drawable.Drawable arg0, java.lang.Runnable arg1);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.graphics.drawable.Drawable.Callback))]
		internal sealed partial class Callback_ : java.lang.Object, Callback
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal Callback_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			void android.graphics.drawable.Drawable.Callback.invalidateDrawable(android.graphics.drawable.Drawable arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.Drawable.Callback_.staticClass, "invalidateDrawable", "(Landroid/graphics/drawable/Drawable;)V", ref global::android.graphics.drawable.Drawable.Callback_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static global::MonoJavaBridge.MethodId _m1;
			void android.graphics.drawable.Drawable.Callback.scheduleDrawable(android.graphics.drawable.Drawable arg0, java.lang.Runnable arg1, long arg2)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.Drawable.Callback_.staticClass, "scheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;J)V", ref global::android.graphics.drawable.Drawable.Callback_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			private static global::MonoJavaBridge.MethodId _m2;
			void android.graphics.drawable.Drawable.Callback.unscheduleDrawable(android.graphics.drawable.Drawable arg0, java.lang.Runnable arg1)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.Drawable.Callback_.staticClass, "unscheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;)V", ref global::android.graphics.drawable.Drawable.Callback_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			static Callback_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.graphics.drawable.Drawable.Callback_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/drawable/Drawable$Callback"));
			}
		}
		[global::MonoJavaBridge.JavaClass(typeof(global::android.graphics.drawable.Drawable.ConstantState_))]
		public abstract partial class ConstantState : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected ConstantState(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public abstract int getChangingConfigurations();
			private static global::MonoJavaBridge.MethodId _m1;
			public abstract global::android.graphics.drawable.Drawable newDrawable();
			private static global::MonoJavaBridge.MethodId _m2;
			public virtual global::android.graphics.drawable.Drawable newDrawable(android.content.res.Resources arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.graphics.drawable.Drawable.ConstantState.staticClass, "newDrawable", "(Landroid/content/res/Resources;)Landroid/graphics/drawable/Drawable;", ref global::android.graphics.drawable.Drawable.ConstantState._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.graphics.drawable.Drawable;
			}
			private static global::MonoJavaBridge.MethodId _m3;
			public ConstantState() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.graphics.drawable.Drawable.ConstantState._m3.native == global::System.IntPtr.Zero)
					global::android.graphics.drawable.Drawable.ConstantState._m3 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.ConstantState.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.drawable.Drawable.ConstantState.staticClass, global::android.graphics.drawable.Drawable.ConstantState._m3);
				Init(@__env, handle);
			}
			static ConstantState()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.graphics.drawable.Drawable.ConstantState.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/drawable/Drawable$ConstantState"));
			}
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.graphics.drawable.Drawable.ConstantState))]
		internal sealed partial class ConstantState_ : android.graphics.drawable.Drawable.ConstantState
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal ConstantState_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public override int getChangingConfigurations()
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.drawable.Drawable.ConstantState_.staticClass, "getChangingConfigurations", "()I", ref global::android.graphics.drawable.Drawable.ConstantState_._m0);
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public override global::android.graphics.drawable.Drawable newDrawable()
			{
				return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.graphics.drawable.Drawable.ConstantState_.staticClass, "newDrawable", "()Landroid/graphics/drawable/Drawable;", ref global::android.graphics.drawable.Drawable.ConstantState_._m1) as android.graphics.drawable.Drawable;
			}
			static ConstantState_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.graphics.drawable.Drawable.ConstantState_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/drawable/Drawable$ConstantState"));
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual int[] getState()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<int>(this, global::android.graphics.drawable.Drawable.staticClass, "getState", "()[I", ref global::android.graphics.drawable.Drawable._m0) as int[];
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual bool setState(int[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.drawable.Drawable.staticClass, "setState", "([I)Z", ref global::android.graphics.drawable.Drawable._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void inflate(android.content.res.Resources arg0, org.xmlpull.v1.XmlPullParser arg1, android.util.AttributeSet arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.Drawable.staticClass, "inflate", "(Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;Landroid/util/AttributeSet;)V", ref global::android.graphics.drawable.Drawable._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public abstract void draw(android.graphics.Canvas arg0);
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void setBounds(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.Drawable.staticClass, "setBounds", "(IIII)V", ref global::android.graphics.drawable.Drawable._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void setBounds(android.graphics.Rect arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.Drawable.staticClass, "setBounds", "(Landroid/graphics/Rect;)V", ref global::android.graphics.drawable.Drawable._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual void copyBounds(android.graphics.Rect arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.Drawable.staticClass, "copyBounds", "(Landroid/graphics/Rect;)V", ref global::android.graphics.drawable.Drawable._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual global::android.graphics.Rect copyBounds()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.graphics.Rect>(this, global::android.graphics.drawable.Drawable.staticClass, "copyBounds", "()Landroid/graphics/Rect;", ref global::android.graphics.drawable.Drawable._m7) as android.graphics.Rect;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual global::android.graphics.Rect getBounds()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.graphics.Rect>(this, global::android.graphics.drawable.Drawable.staticClass, "getBounds", "()Landroid/graphics/Rect;", ref global::android.graphics.drawable.Drawable._m8) as android.graphics.Rect;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual void setChangingConfigurations(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.Drawable.staticClass, "setChangingConfigurations", "(I)V", ref global::android.graphics.drawable.Drawable._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual int getChangingConfigurations()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.drawable.Drawable.staticClass, "getChangingConfigurations", "()I", ref global::android.graphics.drawable.Drawable._m10);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual void setDither(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.Drawable.staticClass, "setDither", "(Z)V", ref global::android.graphics.drawable.Drawable._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual void setFilterBitmap(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.Drawable.staticClass, "setFilterBitmap", "(Z)V", ref global::android.graphics.drawable.Drawable._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual void setCallback(android.graphics.drawable.Drawable.Callback arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.Drawable.staticClass, "setCallback", "(Landroid/graphics/drawable/Drawable$Callback;)V", ref global::android.graphics.drawable.Drawable._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual void invalidateSelf()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.Drawable.staticClass, "invalidateSelf", "()V", ref global::android.graphics.drawable.Drawable._m14);
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual void scheduleSelf(java.lang.Runnable arg0, long arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.Drawable.staticClass, "scheduleSelf", "(Ljava/lang/Runnable;J)V", ref global::android.graphics.drawable.Drawable._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public void scheduleSelf(global::java.lang.RunnableDelegate arg0, long arg1)
		{
			scheduleSelf((global::java.lang.RunnableDelegateWrapper)arg0, arg1);
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual void unscheduleSelf(java.lang.Runnable arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.Drawable.staticClass, "unscheduleSelf", "(Ljava/lang/Runnable;)V", ref global::android.graphics.drawable.Drawable._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void unscheduleSelf(global::java.lang.RunnableDelegate arg0)
		{
			unscheduleSelf((global::java.lang.RunnableDelegateWrapper)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public abstract void setAlpha(int arg0);
		private static global::MonoJavaBridge.MethodId _m18;
		public abstract void setColorFilter(android.graphics.ColorFilter arg0);
		private static global::MonoJavaBridge.MethodId _m19;
		public virtual void setColorFilter(int arg0, android.graphics.PorterDuff.Mode arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.Drawable.staticClass, "setColorFilter", "(ILandroid/graphics/PorterDuff$Mode;)V", ref global::android.graphics.drawable.Drawable._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public virtual void clearColorFilter()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.Drawable.staticClass, "clearColorFilter", "()V", ref global::android.graphics.drawable.Drawable._m20);
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public virtual bool isStateful()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.drawable.Drawable.staticClass, "isStateful", "()Z", ref global::android.graphics.drawable.Drawable._m21);
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public virtual global::android.graphics.drawable.Drawable getCurrent()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.graphics.drawable.Drawable.staticClass, "getCurrent", "()Landroid/graphics/drawable/Drawable;", ref global::android.graphics.drawable.Drawable._m22) as android.graphics.drawable.Drawable;
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public virtual bool setLevel(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.drawable.Drawable.staticClass, "setLevel", "(I)Z", ref global::android.graphics.drawable.Drawable._m23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public virtual int getLevel()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.drawable.Drawable.staticClass, "getLevel", "()I", ref global::android.graphics.drawable.Drawable._m24);
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public virtual bool setVisible(bool arg0, bool arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.drawable.Drawable.staticClass, "setVisible", "(ZZ)Z", ref global::android.graphics.drawable.Drawable._m25, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m26;
		public virtual bool isVisible()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.drawable.Drawable.staticClass, "isVisible", "()Z", ref global::android.graphics.drawable.Drawable._m26);
		}
		private static global::MonoJavaBridge.MethodId _m27;
		public abstract int getOpacity();
		private static global::MonoJavaBridge.MethodId _m28;
		public static int resolveOpacity(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.drawable.Drawable._m28.native == global::System.IntPtr.Zero)
				global::android.graphics.drawable.Drawable._m28 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "resolveOpacity", "(II)I");
			return @__env.CallStaticIntMethod(android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._m28, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m29;
		public virtual global::android.graphics.Region getTransparentRegion()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.graphics.drawable.Drawable.staticClass, "getTransparentRegion", "()Landroid/graphics/Region;", ref global::android.graphics.drawable.Drawable._m29) as android.graphics.Region;
		}
		private static global::MonoJavaBridge.MethodId _m30;
		protected virtual bool onStateChange(int[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.drawable.Drawable.staticClass, "onStateChange", "([I)Z", ref global::android.graphics.drawable.Drawable._m30, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m31;
		protected virtual bool onLevelChange(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.drawable.Drawable.staticClass, "onLevelChange", "(I)Z", ref global::android.graphics.drawable.Drawable._m31, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m32;
		protected virtual void onBoundsChange(android.graphics.Rect arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.Drawable.staticClass, "onBoundsChange", "(Landroid/graphics/Rect;)V", ref global::android.graphics.drawable.Drawable._m32, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m33;
		public virtual int getIntrinsicWidth()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.drawable.Drawable.staticClass, "getIntrinsicWidth", "()I", ref global::android.graphics.drawable.Drawable._m33);
		}
		private static global::MonoJavaBridge.MethodId _m34;
		public virtual int getIntrinsicHeight()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.drawable.Drawable.staticClass, "getIntrinsicHeight", "()I", ref global::android.graphics.drawable.Drawable._m34);
		}
		private static global::MonoJavaBridge.MethodId _m35;
		public virtual int getMinimumWidth()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.drawable.Drawable.staticClass, "getMinimumWidth", "()I", ref global::android.graphics.drawable.Drawable._m35);
		}
		private static global::MonoJavaBridge.MethodId _m36;
		public virtual int getMinimumHeight()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.drawable.Drawable.staticClass, "getMinimumHeight", "()I", ref global::android.graphics.drawable.Drawable._m36);
		}
		private static global::MonoJavaBridge.MethodId _m37;
		public virtual bool getPadding(android.graphics.Rect arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.drawable.Drawable.staticClass, "getPadding", "(Landroid/graphics/Rect;)Z", ref global::android.graphics.drawable.Drawable._m37, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m38;
		public virtual global::android.graphics.drawable.Drawable mutate()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.graphics.drawable.Drawable.staticClass, "mutate", "()Landroid/graphics/drawable/Drawable;", ref global::android.graphics.drawable.Drawable._m38) as android.graphics.drawable.Drawable;
		}
		private static global::MonoJavaBridge.MethodId _m39;
		public static global::android.graphics.drawable.Drawable createFromStream(java.io.InputStream arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.drawable.Drawable._m39.native == global::System.IntPtr.Zero)
				global::android.graphics.drawable.Drawable._m39 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "createFromStream", "(Ljava/io/InputStream;Ljava/lang/String;)Landroid/graphics/drawable/Drawable;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._m39, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.graphics.drawable.Drawable;
		}
		private static global::MonoJavaBridge.MethodId _m40;
		public static global::android.graphics.drawable.Drawable createFromResourceStream(android.content.res.Resources arg0, android.util.TypedValue arg1, java.io.InputStream arg2, java.lang.String arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.drawable.Drawable._m40.native == global::System.IntPtr.Zero)
				global::android.graphics.drawable.Drawable._m40 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "createFromResourceStream", "(Landroid/content/res/Resources;Landroid/util/TypedValue;Ljava/io/InputStream;Ljava/lang/String;)Landroid/graphics/drawable/Drawable;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._m40, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.graphics.drawable.Drawable;
		}
		private static global::MonoJavaBridge.MethodId _m41;
		public static global::android.graphics.drawable.Drawable createFromResourceStream(android.content.res.Resources arg0, android.util.TypedValue arg1, java.io.InputStream arg2, java.lang.String arg3, android.graphics.BitmapFactory.Options arg4)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.drawable.Drawable._m41.native == global::System.IntPtr.Zero)
				global::android.graphics.drawable.Drawable._m41 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "createFromResourceStream", "(Landroid/content/res/Resources;Landroid/util/TypedValue;Ljava/io/InputStream;Ljava/lang/String;Landroid/graphics/BitmapFactory$Options;)Landroid/graphics/drawable/Drawable;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._m41, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as android.graphics.drawable.Drawable;
		}
		private static global::MonoJavaBridge.MethodId _m42;
		public static global::android.graphics.drawable.Drawable createFromXml(android.content.res.Resources arg0, org.xmlpull.v1.XmlPullParser arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.drawable.Drawable._m42.native == global::System.IntPtr.Zero)
				global::android.graphics.drawable.Drawable._m42 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "createFromXml", "(Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;)Landroid/graphics/drawable/Drawable;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._m42, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.graphics.drawable.Drawable;
		}
		private static global::MonoJavaBridge.MethodId _m43;
		public static global::android.graphics.drawable.Drawable createFromXmlInner(android.content.res.Resources arg0, org.xmlpull.v1.XmlPullParser arg1, android.util.AttributeSet arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.drawable.Drawable._m43.native == global::System.IntPtr.Zero)
				global::android.graphics.drawable.Drawable._m43 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "createFromXmlInner", "(Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;Landroid/util/AttributeSet;)Landroid/graphics/drawable/Drawable;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._m43, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.graphics.drawable.Drawable;
		}
		private static global::MonoJavaBridge.MethodId _m44;
		public static global::android.graphics.drawable.Drawable createFromPath(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.drawable.Drawable._m44.native == global::System.IntPtr.Zero)
				global::android.graphics.drawable.Drawable._m44 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "createFromPath", "(Ljava/lang/String;)Landroid/graphics/drawable/Drawable;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._m44, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.drawable.Drawable;
		}
		private static global::MonoJavaBridge.MethodId _m45;
		public virtual global::android.graphics.drawable.Drawable.ConstantState getConstantState()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.graphics.drawable.Drawable.staticClass, "getConstantState", "()Landroid/graphics/drawable/Drawable$ConstantState;", ref global::android.graphics.drawable.Drawable._m45) as android.graphics.drawable.Drawable.ConstantState;
		}
		private static global::MonoJavaBridge.MethodId _m46;
		public Drawable() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.drawable.Drawable._m46.native == global::System.IntPtr.Zero)
				global::android.graphics.drawable.Drawable._m46 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._m46);
			Init(@__env, handle);
		}
		static Drawable()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.drawable.Drawable.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/drawable/Drawable"));
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.graphics.drawable.Drawable))]
	internal sealed partial class Drawable_ : android.graphics.drawable.Drawable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Drawable_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override void draw(android.graphics.Canvas arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.Drawable_.staticClass, "draw", "(Landroid/graphics/Canvas;)V", ref global::android.graphics.drawable.Drawable_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override void setAlpha(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.Drawable_.staticClass, "setAlpha", "(I)V", ref global::android.graphics.drawable.Drawable_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override void setColorFilter(android.graphics.ColorFilter arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.Drawable_.staticClass, "setColorFilter", "(Landroid/graphics/ColorFilter;)V", ref global::android.graphics.drawable.Drawable_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override int getOpacity()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.drawable.Drawable_.staticClass, "getOpacity", "()I", ref global::android.graphics.drawable.Drawable_._m3);
		}
		static Drawable_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.drawable.Drawable_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/drawable/Drawable"));
		}
	}
}
