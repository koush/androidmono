namespace android.text
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.text.Layout_))]
	public abstract partial class Layout : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Layout()
		{
			InitJNI();
		}
		protected Layout(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class Alignment : java.lang.Enum
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static Alignment()
			{
				InitJNI();
			}
			internal Alignment(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _values12821;
			public static global::android.text.Layout.Alignment[] values()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.text.Layout.Alignment>(@__env.CallStaticObjectMethod(android.text.Layout.Alignment.staticClass, global::android.text.Layout.Alignment._values12821)) as android.text.Layout.Alignment[];
			}
			internal static global::MonoJavaBridge.MethodId _valueOf12822;
			public static global::android.text.Layout.Alignment valueOf(java.lang.String arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.text.Layout.Alignment>(@__env.CallStaticObjectMethod(android.text.Layout.Alignment.staticClass, global::android.text.Layout.Alignment._valueOf12822, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.text.Layout.Alignment;
			}
			internal static global::MonoJavaBridge.FieldId _ALIGN_CENTER12823;
			public static global::android.text.Layout.Alignment ALIGN_CENTER
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.text.Layout.Alignment>(@__env.GetStaticObjectField(global::android.text.Layout.Alignment.staticClass, _ALIGN_CENTER12823)) as android.text.Layout.Alignment;
				}
			}
			internal static global::MonoJavaBridge.FieldId _ALIGN_NORMAL12824;
			public static global::android.text.Layout.Alignment ALIGN_NORMAL
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.text.Layout.Alignment>(@__env.GetStaticObjectField(global::android.text.Layout.Alignment.staticClass, _ALIGN_NORMAL12824)) as android.text.Layout.Alignment;
				}
			}
			internal static global::MonoJavaBridge.FieldId _ALIGN_OPPOSITE12825;
			public static global::android.text.Layout.Alignment ALIGN_OPPOSITE
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.text.Layout.Alignment>(@__env.GetStaticObjectField(global::android.text.Layout.Alignment.staticClass, _ALIGN_OPPOSITE12825)) as android.text.Layout.Alignment;
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.text.Layout.Alignment.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/Layout$Alignment"));
				global::android.text.Layout.Alignment._values12821 = @__env.GetStaticMethodIDNoThrow(global::android.text.Layout.Alignment.staticClass, "values", "()[Landroid/text/Layout/Alignment;");
				global::android.text.Layout.Alignment._valueOf12822 = @__env.GetStaticMethodIDNoThrow(global::android.text.Layout.Alignment.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/text/Layout$Alignment;");
				global::android.text.Layout.Alignment._ALIGN_CENTER12823 = @__env.GetStaticFieldIDNoThrow(global::android.text.Layout.Alignment.staticClass, "ALIGN_CENTER", "Landroid/text/Layout$Alignment;");
				global::android.text.Layout.Alignment._ALIGN_NORMAL12824 = @__env.GetStaticFieldIDNoThrow(global::android.text.Layout.Alignment.staticClass, "ALIGN_NORMAL", "Landroid/text/Layout$Alignment;");
				global::android.text.Layout.Alignment._ALIGN_OPPOSITE12825 = @__env.GetStaticFieldIDNoThrow(global::android.text.Layout.Alignment.staticClass, "ALIGN_OPPOSITE", "Landroid/text/Layout$Alignment;");
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class Directions : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static Directions()
			{
				InitJNI();
			}
			protected Directions(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.text.Layout.Directions.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/Layout$Directions"));
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLineWidth12826;
		public virtual float getLineWidth(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.text.Layout._getLineWidth12826, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.text.Layout.staticClass, global::android.text.Layout._getLineWidth12826, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getText12827;
		public virtual global::java.lang.CharSequence getText()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.Layout._getText12827)) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.Layout.staticClass, global::android.text.Layout._getText12827)) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _draw12828;
		public virtual void draw(android.graphics.Canvas arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.Layout._draw12828, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.Layout.staticClass, global::android.text.Layout._draw12828, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _draw12829;
		public virtual void draw(android.graphics.Canvas arg0, android.graphics.Path arg1, android.graphics.Paint arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.Layout._draw12829, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.Layout.staticClass, global::android.text.Layout._draw12829, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _getWidth12830;
		public virtual int getWidth()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.Layout._getWidth12830);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.Layout.staticClass, global::android.text.Layout._getWidth12830);
		}
		internal static global::MonoJavaBridge.MethodId _getHeight12831;
		public virtual int getHeight()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.Layout._getHeight12831);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.Layout.staticClass, global::android.text.Layout._getHeight12831);
		}
		internal static global::MonoJavaBridge.MethodId _getPaint12832;
		public virtual global::android.text.TextPaint getPaint()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.text.Layout._getPaint12832)) as android.text.TextPaint;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.Layout.staticClass, global::android.text.Layout._getPaint12832)) as android.text.TextPaint;
		}
		internal static global::MonoJavaBridge.MethodId _getLineCount12833;
		public abstract int getLineCount();
		internal static global::MonoJavaBridge.MethodId _getLineBounds12834;
		public virtual int getLineBounds(int arg0, android.graphics.Rect arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.Layout._getLineBounds12834, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.Layout.staticClass, global::android.text.Layout._getLineBounds12834, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getDesiredWidth12835;
		public static float getDesiredWidth(java.lang.CharSequence arg0, int arg1, int arg2, android.text.TextPaint arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticFloatMethod(android.text.Layout.staticClass, global::android.text.Layout._getDesiredWidth12835, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		public static float getDesiredWidth(string arg0, int arg1, int arg2, android.text.TextPaint arg3)
		{
			return getDesiredWidth((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2, arg3);
		}
		internal static global::MonoJavaBridge.MethodId _getDesiredWidth12836;
		public static float getDesiredWidth(java.lang.CharSequence arg0, android.text.TextPaint arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticFloatMethod(android.text.Layout.staticClass, global::android.text.Layout._getDesiredWidth12836, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public static float getDesiredWidth(string arg0, android.text.TextPaint arg1)
		{
			return getDesiredWidth((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
		}
		internal static global::MonoJavaBridge.MethodId _getEllipsizedWidth12837;
		public virtual int getEllipsizedWidth()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.Layout._getEllipsizedWidth12837);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.Layout.staticClass, global::android.text.Layout._getEllipsizedWidth12837);
		}
		internal static global::MonoJavaBridge.MethodId _increaseWidthTo12838;
		public virtual void increaseWidthTo(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.Layout._increaseWidthTo12838, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.Layout.staticClass, global::android.text.Layout._increaseWidthTo12838, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getAlignment12839;
		public virtual global::android.text.Layout.Alignment getAlignment()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.text.Layout.Alignment>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.Layout._getAlignment12839)) as android.text.Layout.Alignment;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.text.Layout.Alignment>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.Layout.staticClass, global::android.text.Layout._getAlignment12839)) as android.text.Layout.Alignment;
		}
		internal static global::MonoJavaBridge.MethodId _getSpacingMultiplier12840;
		public virtual float getSpacingMultiplier()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.text.Layout._getSpacingMultiplier12840);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.text.Layout.staticClass, global::android.text.Layout._getSpacingMultiplier12840);
		}
		internal static global::MonoJavaBridge.MethodId _getSpacingAdd12841;
		public virtual float getSpacingAdd()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.text.Layout._getSpacingAdd12841);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.text.Layout.staticClass, global::android.text.Layout._getSpacingAdd12841);
		}
		internal static global::MonoJavaBridge.MethodId _getLineTop12842;
		public abstract int getLineTop(int arg0);
		internal static global::MonoJavaBridge.MethodId _getLineDescent12843;
		public abstract int getLineDescent(int arg0);
		internal static global::MonoJavaBridge.MethodId _getLineStart12844;
		public abstract int getLineStart(int arg0);
		internal static global::MonoJavaBridge.MethodId _getParagraphDirection12845;
		public abstract int getParagraphDirection(int arg0);
		internal static global::MonoJavaBridge.MethodId _getLineContainsTab12846;
		public abstract bool getLineContainsTab(int arg0);
		internal static global::MonoJavaBridge.MethodId _getLineDirections12847;
		public abstract global::android.text.Layout.Directions getLineDirections(int arg0);
		internal static global::MonoJavaBridge.MethodId _getTopPadding12848;
		public abstract int getTopPadding();
		internal static global::MonoJavaBridge.MethodId _getBottomPadding12849;
		public abstract int getBottomPadding();
		internal static global::MonoJavaBridge.MethodId _getPrimaryHorizontal12850;
		public virtual float getPrimaryHorizontal(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.text.Layout._getPrimaryHorizontal12850, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.text.Layout.staticClass, global::android.text.Layout._getPrimaryHorizontal12850, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getSecondaryHorizontal12851;
		public virtual float getSecondaryHorizontal(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.text.Layout._getSecondaryHorizontal12851, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.text.Layout.staticClass, global::android.text.Layout._getSecondaryHorizontal12851, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLineLeft12852;
		public virtual float getLineLeft(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.text.Layout._getLineLeft12852, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.text.Layout.staticClass, global::android.text.Layout._getLineLeft12852, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLineRight12853;
		public virtual float getLineRight(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.text.Layout._getLineRight12853, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.text.Layout.staticClass, global::android.text.Layout._getLineRight12853, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLineMax12854;
		public virtual float getLineMax(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.text.Layout._getLineMax12854, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.text.Layout.staticClass, global::android.text.Layout._getLineMax12854, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLineForVertical12855;
		public virtual int getLineForVertical(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.Layout._getLineForVertical12855, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.Layout.staticClass, global::android.text.Layout._getLineForVertical12855, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLineForOffset12856;
		public virtual int getLineForOffset(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.Layout._getLineForOffset12856, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.Layout.staticClass, global::android.text.Layout._getLineForOffset12856, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getOffsetForHorizontal12857;
		public virtual int getOffsetForHorizontal(int arg0, float arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.Layout._getOffsetForHorizontal12857, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.Layout.staticClass, global::android.text.Layout._getOffsetForHorizontal12857, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getLineEnd12858;
		public virtual int getLineEnd(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.Layout._getLineEnd12858, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.Layout.staticClass, global::android.text.Layout._getLineEnd12858, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLineVisibleEnd12859;
		public virtual int getLineVisibleEnd(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.Layout._getLineVisibleEnd12859, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.Layout.staticClass, global::android.text.Layout._getLineVisibleEnd12859, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLineBottom12860;
		public virtual int getLineBottom(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.Layout._getLineBottom12860, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.Layout.staticClass, global::android.text.Layout._getLineBottom12860, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLineBaseline12861;
		public virtual int getLineBaseline(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.Layout._getLineBaseline12861, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.Layout.staticClass, global::android.text.Layout._getLineBaseline12861, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLineAscent12862;
		public virtual int getLineAscent(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.Layout._getLineAscent12862, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.Layout.staticClass, global::android.text.Layout._getLineAscent12862, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getOffsetToLeftOf12863;
		public virtual int getOffsetToLeftOf(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.Layout._getOffsetToLeftOf12863, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.Layout.staticClass, global::android.text.Layout._getOffsetToLeftOf12863, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getOffsetToRightOf12864;
		public virtual int getOffsetToRightOf(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.Layout._getOffsetToRightOf12864, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.Layout.staticClass, global::android.text.Layout._getOffsetToRightOf12864, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getCursorPath12865;
		public virtual void getCursorPath(int arg0, android.graphics.Path arg1, java.lang.CharSequence arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.Layout._getCursorPath12865, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.Layout.staticClass, global::android.text.Layout._getCursorPath12865, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public void getCursorPath(int arg0, android.graphics.Path arg1, string arg2)
		{
			getCursorPath(arg0, arg1, (global::java.lang.CharSequence)(global::java.lang.String)arg2);
		}
		internal static global::MonoJavaBridge.MethodId _getSelectionPath12866;
		public virtual void getSelectionPath(int arg0, int arg1, android.graphics.Path arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.Layout._getSelectionPath12866, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.Layout.staticClass, global::android.text.Layout._getSelectionPath12866, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _getParagraphAlignment12867;
		public virtual global::android.text.Layout.Alignment getParagraphAlignment(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.text.Layout.Alignment>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.Layout._getParagraphAlignment12867, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.text.Layout.Alignment;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.text.Layout.Alignment>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.Layout.staticClass, global::android.text.Layout._getParagraphAlignment12867, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.text.Layout.Alignment;
		}
		internal static global::MonoJavaBridge.MethodId _getParagraphLeft12868;
		public virtual int getParagraphLeft(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.Layout._getParagraphLeft12868, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.Layout.staticClass, global::android.text.Layout._getParagraphLeft12868, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getParagraphRight12869;
		public virtual int getParagraphRight(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.Layout._getParagraphRight12869, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.Layout.staticClass, global::android.text.Layout._getParagraphRight12869, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isSpanned12870;
		protected virtual bool isSpanned()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.text.Layout._isSpanned12870);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.text.Layout.staticClass, global::android.text.Layout._isSpanned12870);
		}
		internal static global::MonoJavaBridge.MethodId _getEllipsisStart12871;
		public abstract int getEllipsisStart(int arg0);
		internal static global::MonoJavaBridge.MethodId _getEllipsisCount12872;
		public abstract int getEllipsisCount(int arg0);
		internal static global::MonoJavaBridge.MethodId _Layout12873;
		protected Layout(java.lang.CharSequence arg0, android.text.TextPaint arg1, int arg2, android.text.Layout.Alignment arg3, float arg4, float arg5) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.Layout.staticClass, global::android.text.Layout._Layout12873, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			Init(@__env, handle);
		}
		public static int DIR_LEFT_TO_RIGHT
		{
			get
			{
				return 1;
			}
		}
		public static int DIR_RIGHT_TO_LEFT
		{
			get
			{
				return -1;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.Layout.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/Layout"));
			global::android.text.Layout._getLineWidth12826 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getLineWidth", "(I)F");
			global::android.text.Layout._getText12827 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getText", "()Ljava/lang/CharSequence;");
			global::android.text.Layout._draw12828 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "draw", "(Landroid/graphics/Canvas;)V");
			global::android.text.Layout._draw12829 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "draw", "(Landroid/graphics/Canvas;Landroid/graphics/Path;Landroid/graphics/Paint;I)V");
			global::android.text.Layout._getWidth12830 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getWidth", "()I");
			global::android.text.Layout._getHeight12831 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getHeight", "()I");
			global::android.text.Layout._getPaint12832 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getPaint", "()Landroid/text/TextPaint;");
			global::android.text.Layout._getLineCount12833 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getLineCount", "()I");
			global::android.text.Layout._getLineBounds12834 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getLineBounds", "(ILandroid/graphics/Rect;)I");
			global::android.text.Layout._getDesiredWidth12835 = @__env.GetStaticMethodIDNoThrow(global::android.text.Layout.staticClass, "getDesiredWidth", "(Ljava/lang/CharSequence;IILandroid/text/TextPaint;)F");
			global::android.text.Layout._getDesiredWidth12836 = @__env.GetStaticMethodIDNoThrow(global::android.text.Layout.staticClass, "getDesiredWidth", "(Ljava/lang/CharSequence;Landroid/text/TextPaint;)F");
			global::android.text.Layout._getEllipsizedWidth12837 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getEllipsizedWidth", "()I");
			global::android.text.Layout._increaseWidthTo12838 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "increaseWidthTo", "(I)V");
			global::android.text.Layout._getAlignment12839 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getAlignment", "()Landroid/text/Layout$Alignment;");
			global::android.text.Layout._getSpacingMultiplier12840 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getSpacingMultiplier", "()F");
			global::android.text.Layout._getSpacingAdd12841 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getSpacingAdd", "()F");
			global::android.text.Layout._getLineTop12842 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getLineTop", "(I)I");
			global::android.text.Layout._getLineDescent12843 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getLineDescent", "(I)I");
			global::android.text.Layout._getLineStart12844 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getLineStart", "(I)I");
			global::android.text.Layout._getParagraphDirection12845 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getParagraphDirection", "(I)I");
			global::android.text.Layout._getLineContainsTab12846 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getLineContainsTab", "(I)Z");
			global::android.text.Layout._getLineDirections12847 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getLineDirections", "(I)Landroid/text/Layout$Directions;");
			global::android.text.Layout._getTopPadding12848 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getTopPadding", "()I");
			global::android.text.Layout._getBottomPadding12849 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getBottomPadding", "()I");
			global::android.text.Layout._getPrimaryHorizontal12850 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getPrimaryHorizontal", "(I)F");
			global::android.text.Layout._getSecondaryHorizontal12851 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getSecondaryHorizontal", "(I)F");
			global::android.text.Layout._getLineLeft12852 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getLineLeft", "(I)F");
			global::android.text.Layout._getLineRight12853 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getLineRight", "(I)F");
			global::android.text.Layout._getLineMax12854 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getLineMax", "(I)F");
			global::android.text.Layout._getLineForVertical12855 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getLineForVertical", "(I)I");
			global::android.text.Layout._getLineForOffset12856 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getLineForOffset", "(I)I");
			global::android.text.Layout._getOffsetForHorizontal12857 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getOffsetForHorizontal", "(IF)I");
			global::android.text.Layout._getLineEnd12858 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getLineEnd", "(I)I");
			global::android.text.Layout._getLineVisibleEnd12859 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getLineVisibleEnd", "(I)I");
			global::android.text.Layout._getLineBottom12860 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getLineBottom", "(I)I");
			global::android.text.Layout._getLineBaseline12861 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getLineBaseline", "(I)I");
			global::android.text.Layout._getLineAscent12862 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getLineAscent", "(I)I");
			global::android.text.Layout._getOffsetToLeftOf12863 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getOffsetToLeftOf", "(I)I");
			global::android.text.Layout._getOffsetToRightOf12864 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getOffsetToRightOf", "(I)I");
			global::android.text.Layout._getCursorPath12865 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getCursorPath", "(ILandroid/graphics/Path;Ljava/lang/CharSequence;)V");
			global::android.text.Layout._getSelectionPath12866 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getSelectionPath", "(IILandroid/graphics/Path;)V");
			global::android.text.Layout._getParagraphAlignment12867 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getParagraphAlignment", "(I)Landroid/text/Layout$Alignment;");
			global::android.text.Layout._getParagraphLeft12868 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getParagraphLeft", "(I)I");
			global::android.text.Layout._getParagraphRight12869 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getParagraphRight", "(I)I");
			global::android.text.Layout._isSpanned12870 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "isSpanned", "()Z");
			global::android.text.Layout._getEllipsisStart12871 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getEllipsisStart", "(I)I");
			global::android.text.Layout._getEllipsisCount12872 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getEllipsisCount", "(I)I");
			global::android.text.Layout._Layout12873 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "<init>", "(Ljava/lang/CharSequence;Landroid/text/TextPaint;ILandroid/text/Layout$Alignment;FF)V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.text.Layout))]
	internal sealed partial class Layout_ : android.text.Layout
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Layout_()
		{
			InitJNI();
		}
		internal Layout_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getLineCount12876;
		public override int getLineCount()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.Layout_._getLineCount12876);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.Layout_.staticClass, global::android.text.Layout_._getLineCount12876);
		}
		internal static global::MonoJavaBridge.MethodId _getLineTop12877;
		public override int getLineTop(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.Layout_._getLineTop12877, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.Layout_.staticClass, global::android.text.Layout_._getLineTop12877, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLineDescent12878;
		public override int getLineDescent(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.Layout_._getLineDescent12878, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.Layout_.staticClass, global::android.text.Layout_._getLineDescent12878, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLineStart12879;
		public override int getLineStart(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.Layout_._getLineStart12879, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.Layout_.staticClass, global::android.text.Layout_._getLineStart12879, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getParagraphDirection12880;
		public override int getParagraphDirection(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.Layout_._getParagraphDirection12880, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.Layout_.staticClass, global::android.text.Layout_._getParagraphDirection12880, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLineContainsTab12881;
		public override bool getLineContainsTab(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.text.Layout_._getLineContainsTab12881, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.text.Layout_.staticClass, global::android.text.Layout_._getLineContainsTab12881, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLineDirections12882;
		public override global::android.text.Layout.Directions getLineDirections(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.text.Layout_._getLineDirections12882, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.text.Layout.Directions;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.Layout_.staticClass, global::android.text.Layout_._getLineDirections12882, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.text.Layout.Directions;
		}
		internal static global::MonoJavaBridge.MethodId _getTopPadding12883;
		public override int getTopPadding()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.Layout_._getTopPadding12883);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.Layout_.staticClass, global::android.text.Layout_._getTopPadding12883);
		}
		internal static global::MonoJavaBridge.MethodId _getBottomPadding12884;
		public override int getBottomPadding()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.Layout_._getBottomPadding12884);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.Layout_.staticClass, global::android.text.Layout_._getBottomPadding12884);
		}
		internal static global::MonoJavaBridge.MethodId _getEllipsisStart12885;
		public override int getEllipsisStart(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.Layout_._getEllipsisStart12885, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.Layout_.staticClass, global::android.text.Layout_._getEllipsisStart12885, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getEllipsisCount12886;
		public override int getEllipsisCount(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.Layout_._getEllipsisCount12886, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.Layout_.staticClass, global::android.text.Layout_._getEllipsisCount12886, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.Layout_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/Layout"));
			global::android.text.Layout_._getLineCount12876 = @__env.GetMethodIDNoThrow(global::android.text.Layout_.staticClass, "getLineCount", "()I");
			global::android.text.Layout_._getLineTop12877 = @__env.GetMethodIDNoThrow(global::android.text.Layout_.staticClass, "getLineTop", "(I)I");
			global::android.text.Layout_._getLineDescent12878 = @__env.GetMethodIDNoThrow(global::android.text.Layout_.staticClass, "getLineDescent", "(I)I");
			global::android.text.Layout_._getLineStart12879 = @__env.GetMethodIDNoThrow(global::android.text.Layout_.staticClass, "getLineStart", "(I)I");
			global::android.text.Layout_._getParagraphDirection12880 = @__env.GetMethodIDNoThrow(global::android.text.Layout_.staticClass, "getParagraphDirection", "(I)I");
			global::android.text.Layout_._getLineContainsTab12881 = @__env.GetMethodIDNoThrow(global::android.text.Layout_.staticClass, "getLineContainsTab", "(I)Z");
			global::android.text.Layout_._getLineDirections12882 = @__env.GetMethodIDNoThrow(global::android.text.Layout_.staticClass, "getLineDirections", "(I)Landroid/text/Layout$Directions;");
			global::android.text.Layout_._getTopPadding12883 = @__env.GetMethodIDNoThrow(global::android.text.Layout_.staticClass, "getTopPadding", "()I");
			global::android.text.Layout_._getBottomPadding12884 = @__env.GetMethodIDNoThrow(global::android.text.Layout_.staticClass, "getBottomPadding", "()I");
			global::android.text.Layout_._getEllipsisStart12885 = @__env.GetMethodIDNoThrow(global::android.text.Layout_.staticClass, "getEllipsisStart", "(I)I");
			global::android.text.Layout_._getEllipsisCount12886 = @__env.GetMethodIDNoThrow(global::android.text.Layout_.staticClass, "getEllipsisCount", "(I)I");
		}
	}
}
