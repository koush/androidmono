namespace android.graphics.drawable
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DrawableContainer : android.graphics.drawable.Drawable, android.graphics.drawable.Drawable.Callback
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected DrawableContainer(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass(typeof(global::android.graphics.drawable.DrawableContainer.DrawableContainerState_))]
		public abstract partial class DrawableContainerState : android.graphics.drawable.Drawable.ConstantState
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected DrawableContainerState(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public override int getChangingConfigurations()
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, "getChangingConfigurations", "()I", ref global::android.graphics.drawable.DrawableContainer.DrawableContainerState._m0);
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public virtual bool isStateful()
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, "isStateful", "()Z", ref global::android.graphics.drawable.DrawableContainer.DrawableContainerState._m1);
			}
			private static global::MonoJavaBridge.MethodId _m2;
			public virtual int getOpacity()
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, "getOpacity", "()I", ref global::android.graphics.drawable.DrawableContainer.DrawableContainerState._m2);
			}
			private static global::MonoJavaBridge.MethodId _m3;
			public virtual int getChildCount()
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, "getChildCount", "()I", ref global::android.graphics.drawable.DrawableContainer.DrawableContainerState._m3);
			}
			private static global::MonoJavaBridge.MethodId _m4;
			public virtual int addChild(android.graphics.drawable.Drawable arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, "addChild", "(Landroid/graphics/drawable/Drawable;)I", ref global::android.graphics.drawable.DrawableContainer.DrawableContainerState._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static global::MonoJavaBridge.MethodId _m5;
			public virtual global::android.graphics.drawable.Drawable[] getChildren()
			{
				return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<android.graphics.drawable.Drawable>(this, global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, "getChildren", "()[Landroid/graphics/drawable/Drawable;", ref global::android.graphics.drawable.DrawableContainer.DrawableContainerState._m5) as android.graphics.drawable.Drawable[];
			}
			private static global::MonoJavaBridge.MethodId _m6;
			public virtual void setVariablePadding(bool arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, "setVariablePadding", "(Z)V", ref global::android.graphics.drawable.DrawableContainer.DrawableContainerState._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static global::MonoJavaBridge.MethodId _m7;
			public virtual global::android.graphics.Rect getConstantPadding()
			{
				return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.graphics.Rect>(this, global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, "getConstantPadding", "()Landroid/graphics/Rect;", ref global::android.graphics.drawable.DrawableContainer.DrawableContainerState._m7) as android.graphics.Rect;
			}
			private static global::MonoJavaBridge.MethodId _m8;
			public virtual void setConstantSize(bool arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, "setConstantSize", "(Z)V", ref global::android.graphics.drawable.DrawableContainer.DrawableContainerState._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static global::MonoJavaBridge.MethodId _m9;
			public virtual bool isConstantSize()
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, "isConstantSize", "()Z", ref global::android.graphics.drawable.DrawableContainer.DrawableContainerState._m9);
			}
			private static global::MonoJavaBridge.MethodId _m10;
			public virtual int getConstantWidth()
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, "getConstantWidth", "()I", ref global::android.graphics.drawable.DrawableContainer.DrawableContainerState._m10);
			}
			private static global::MonoJavaBridge.MethodId _m11;
			public virtual int getConstantHeight()
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, "getConstantHeight", "()I", ref global::android.graphics.drawable.DrawableContainer.DrawableContainerState._m11);
			}
			private static global::MonoJavaBridge.MethodId _m12;
			public virtual int getConstantMinimumWidth()
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, "getConstantMinimumWidth", "()I", ref global::android.graphics.drawable.DrawableContainer.DrawableContainerState._m12);
			}
			private static global::MonoJavaBridge.MethodId _m13;
			public virtual int getConstantMinimumHeight()
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, "getConstantMinimumHeight", "()I", ref global::android.graphics.drawable.DrawableContainer.DrawableContainerState._m13);
			}
			private static global::MonoJavaBridge.MethodId _m14;
			public virtual void growArray(int arg0, int arg1)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, "growArray", "(II)V", ref global::android.graphics.drawable.DrawableContainer.DrawableContainerState._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static global::MonoJavaBridge.MethodId _m15;
			public virtual bool canConstantState()
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, "canConstantState", "()Z", ref global::android.graphics.drawable.DrawableContainer.DrawableContainerState._m15);
			}
			static DrawableContainerState()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/drawable/DrawableContainer$DrawableContainerState"));
			}
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.graphics.drawable.DrawableContainer.DrawableContainerState))]
		internal sealed partial class DrawableContainerState_ : android.graphics.drawable.DrawableContainer.DrawableContainerState
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal DrawableContainerState_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public override global::android.graphics.drawable.Drawable newDrawable()
			{
				return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.graphics.drawable.DrawableContainer.DrawableContainerState_.staticClass, "newDrawable", "()Landroid/graphics/drawable/Drawable;", ref global::android.graphics.drawable.DrawableContainer.DrawableContainerState_._m0) as android.graphics.drawable.Drawable;
			}
			static DrawableContainerState_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.graphics.drawable.DrawableContainer.DrawableContainerState_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/drawable/DrawableContainer$DrawableContainerState"));
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override void draw(android.graphics.Canvas arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.DrawableContainer.staticClass, "draw", "(Landroid/graphics/Canvas;)V", ref global::android.graphics.drawable.DrawableContainer._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int ChangingConfigurations
		{
			get
			{
				return getChangingConfigurations();
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override int getChangingConfigurations()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.drawable.DrawableContainer.staticClass, "getChangingConfigurations", "()I", ref global::android.graphics.drawable.DrawableContainer._m1);
		}
		public new bool Dither
		{
			set
			{
				setDither(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override void setDither(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.DrawableContainer.staticClass, "setDither", "(Z)V", ref global::android.graphics.drawable.DrawableContainer._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Alpha
		{
			set
			{
				setAlpha(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override void setAlpha(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.DrawableContainer.staticClass, "setAlpha", "(I)V", ref global::android.graphics.drawable.DrawableContainer._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.graphics.ColorFilter ColorFilter
		{
			set
			{
				setColorFilter(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override void setColorFilter(android.graphics.ColorFilter arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.DrawableContainer.staticClass, "setColorFilter", "(Landroid/graphics/ColorFilter;)V", ref global::android.graphics.drawable.DrawableContainer._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override bool isStateful()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.drawable.DrawableContainer.staticClass, "isStateful", "()Z", ref global::android.graphics.drawable.DrawableContainer._m5);
		}
		public new global::android.graphics.drawable.Drawable Current
		{
			get
			{
				return getCurrent();
			}
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public override global::android.graphics.drawable.Drawable getCurrent()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.graphics.drawable.DrawableContainer.staticClass, "getCurrent", "()Landroid/graphics/drawable/Drawable;", ref global::android.graphics.drawable.DrawableContainer._m6) as android.graphics.drawable.Drawable;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public override bool setVisible(bool arg0, bool arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.drawable.DrawableContainer.staticClass, "setVisible", "(ZZ)Z", ref global::android.graphics.drawable.DrawableContainer._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new int Opacity
		{
			get
			{
				return getOpacity();
			}
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public override int getOpacity()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.drawable.DrawableContainer.staticClass, "getOpacity", "()I", ref global::android.graphics.drawable.DrawableContainer._m8);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		protected override bool onStateChange(int[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.drawable.DrawableContainer.staticClass, "onStateChange", "([I)Z", ref global::android.graphics.drawable.DrawableContainer._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		protected override bool onLevelChange(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.drawable.DrawableContainer.staticClass, "onLevelChange", "(I)Z", ref global::android.graphics.drawable.DrawableContainer._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		protected override void onBoundsChange(android.graphics.Rect arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.DrawableContainer.staticClass, "onBoundsChange", "(Landroid/graphics/Rect;)V", ref global::android.graphics.drawable.DrawableContainer._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int IntrinsicWidth
		{
			get
			{
				return getIntrinsicWidth();
			}
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public override int getIntrinsicWidth()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.drawable.DrawableContainer.staticClass, "getIntrinsicWidth", "()I", ref global::android.graphics.drawable.DrawableContainer._m12);
		}
		public new int IntrinsicHeight
		{
			get
			{
				return getIntrinsicHeight();
			}
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public override int getIntrinsicHeight()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.drawable.DrawableContainer.staticClass, "getIntrinsicHeight", "()I", ref global::android.graphics.drawable.DrawableContainer._m13);
		}
		public new int MinimumWidth
		{
			get
			{
				return getMinimumWidth();
			}
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public override int getMinimumWidth()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.drawable.DrawableContainer.staticClass, "getMinimumWidth", "()I", ref global::android.graphics.drawable.DrawableContainer._m14);
		}
		public new int MinimumHeight
		{
			get
			{
				return getMinimumHeight();
			}
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public override int getMinimumHeight()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.drawable.DrawableContainer.staticClass, "getMinimumHeight", "()I", ref global::android.graphics.drawable.DrawableContainer._m15);
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public override bool getPadding(android.graphics.Rect arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.drawable.DrawableContainer.staticClass, "getPadding", "(Landroid/graphics/Rect;)Z", ref global::android.graphics.drawable.DrawableContainer._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public override global::android.graphics.drawable.Drawable mutate()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.graphics.drawable.DrawableContainer.staticClass, "mutate", "()Landroid/graphics/drawable/Drawable;", ref global::android.graphics.drawable.DrawableContainer._m17) as android.graphics.drawable.Drawable;
		}
		public new global::android.graphics.drawable.Drawable.ConstantState ConstantState
		{
			get
			{
				return getConstantState();
			}
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public override global::android.graphics.drawable.Drawable.ConstantState getConstantState()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.graphics.drawable.DrawableContainer.staticClass, "getConstantState", "()Landroid/graphics/drawable/Drawable$ConstantState;", ref global::android.graphics.drawable.DrawableContainer._m18) as android.graphics.drawable.Drawable.ConstantState;
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public virtual void invalidateDrawable(android.graphics.drawable.Drawable arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.DrawableContainer.staticClass, "invalidateDrawable", "(Landroid/graphics/drawable/Drawable;)V", ref global::android.graphics.drawable.DrawableContainer._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public virtual void scheduleDrawable(android.graphics.drawable.Drawable arg0, java.lang.Runnable arg1, long arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.DrawableContainer.staticClass, "scheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;J)V", ref global::android.graphics.drawable.DrawableContainer._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public void scheduleDrawable(android.graphics.drawable.Drawable arg0, global::java.lang.RunnableDelegate arg1, long arg2)
		{
			scheduleDrawable(arg0, (global::java.lang.RunnableDelegateWrapper)arg1, arg2);
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public virtual void unscheduleDrawable(android.graphics.drawable.Drawable arg0, java.lang.Runnable arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.DrawableContainer.staticClass, "unscheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;)V", ref global::android.graphics.drawable.DrawableContainer._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public void unscheduleDrawable(android.graphics.drawable.Drawable arg0, global::java.lang.RunnableDelegate arg1)
		{
			unscheduleDrawable(arg0, (global::java.lang.RunnableDelegateWrapper)arg1);
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public virtual bool selectDrawable(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.drawable.DrawableContainer.staticClass, "selectDrawable", "(I)Z", ref global::android.graphics.drawable.DrawableContainer._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m23;
		protected virtual void setConstantState(android.graphics.drawable.DrawableContainer.DrawableContainerState arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.DrawableContainer.staticClass, "setConstantState", "(Landroid/graphics/drawable/DrawableContainer$DrawableContainerState;)V", ref global::android.graphics.drawable.DrawableContainer._m23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public DrawableContainer() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.drawable.DrawableContainer._m24.native == global::System.IntPtr.Zero)
				global::android.graphics.drawable.DrawableContainer._m24 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.DrawableContainer.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.drawable.DrawableContainer.staticClass, global::android.graphics.drawable.DrawableContainer._m24);
			Init(@__env, handle);
		}
		static DrawableContainer()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.drawable.DrawableContainer.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/drawable/DrawableContainer"));
		}
	}
}
