namespace android.text 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class Layout : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static Layout() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.text.Layout), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		protected Layout(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public sealed class Alignment : java.lang.Enum
		{ 
			internal new static global::java.lang.Class staticClass; 
			static Alignment() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.text.Layout.Alignment), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.text.Layout.Alignment(@__env); 
				} 
			} 
			internal Alignment(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _valueOf6467; 
			public static android.text.Layout.Alignment valueOf(java.lang.String arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.text.Layout.Alignment>(@__env, @__env.CallStaticObjectMethodPtr(android.text.Layout.Alignment.staticClass, _valueOf6467, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _values6468; 
			public static android.text.Layout.Alignment[] values() 
			{ 
				return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.text.Layout.Alignment.staticClass, _values6468)); 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _ALIGN_CENTER6469; 
			public static android.text.Layout.Alignment ALIGN_CENTER
			{ 
				get 
				{ 
					return default(android.text.Layout.Alignment); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _ALIGN_NORMAL6470; 
			public static android.text.Layout.Alignment ALIGN_NORMAL
			{ 
				get 
				{ 
					return default(android.text.Layout.Alignment); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _ALIGN_OPPOSITE6471; 
			public static android.text.Layout.Alignment ALIGN_OPPOSITE
			{ 
				get 
				{ 
					return default(android.text.Layout.Alignment); 
				} 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.text.Layout.Alignment.staticClass = @__class; 
				global::android.text.Layout.Alignment._valueOf6467 = @__env.GetStaticMethodID(global::android.text.Layout.Alignment.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/text/Layout$Alignment;"); 
				global::android.text.Layout.Alignment._values6468 = @__env.GetStaticMethodID(global::android.text.Layout.Alignment.staticClass, "values", "()[Landroid/text/Layout/Alignment;"); 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public class Directions : java.lang.Object
		{ 
			internal static global::java.lang.Class staticClass; 
			static Directions() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.text.Layout.Directions), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.text.Layout.Directions(@__env); 
				} 
			} 
			protected Directions(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.text.Layout.Directions.staticClass = @__class; 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLineWidth6472; 
		public virtual float getLineWidth(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.Layout)) 
				return @__env.CallFloatMethod(this, _getLineWidth6472, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, android.text.Layout.staticClass, _getLineWidth6472, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getText6473; 
		public virtual java.lang.CharSequence getText() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.Layout)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, _getText6473)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.text.Layout.staticClass, _getText6473)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _draw6474; 
		public virtual void draw(android.graphics.Canvas arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.Layout)) 
				@__env.CallVoidMethod(this, _draw6474, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.text.Layout.staticClass, _draw6474, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _draw6475; 
		public virtual void draw(android.graphics.Canvas arg0, android.graphics.Path arg1, android.graphics.Paint arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.Layout)) 
				@__env.CallVoidMethod(this, _draw6475, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.text.Layout.staticClass, _draw6475, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getWidth6476; 
		public virtual int getWidth() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.Layout)) 
				return @__env.CallIntMethod(this, _getWidth6476); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.text.Layout.staticClass, _getWidth6476); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getHeight6477; 
		public virtual int getHeight() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.Layout)) 
				return @__env.CallIntMethod(this, _getHeight6477); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.text.Layout.staticClass, _getHeight6477); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPaint6478; 
		public virtual android.text.TextPaint getPaint() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.Layout)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.text.TextPaint>(@__env, @__env.CallObjectMethodPtr(this, _getPaint6478)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.text.TextPaint>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.text.Layout.staticClass, _getPaint6478)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLineCount6479; 
		public abstract int getLineCount(); 
		internal static global::net.sf.jni4net.jni.MethodId _getLineBounds6480; 
		public virtual int getLineBounds(int arg0, android.graphics.Rect arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.Layout)) 
				return @__env.CallIntMethod(this, _getLineBounds6480, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.text.Layout.staticClass, _getLineBounds6480, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDesiredWidth6481; 
		public static float getDesiredWidth(java.lang.CharSequence arg0, int arg1, int arg2, android.text.TextPaint arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticFloatMethod(android.text.Layout.staticClass, _getDesiredWidth6481, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDesiredWidth6482; 
		public static float getDesiredWidth(java.lang.CharSequence arg0, android.text.TextPaint arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticFloatMethod(android.text.Layout.staticClass, _getDesiredWidth6482, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getEllipsizedWidth6483; 
		public virtual int getEllipsizedWidth() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.Layout)) 
				return @__env.CallIntMethod(this, _getEllipsizedWidth6483); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.text.Layout.staticClass, _getEllipsizedWidth6483); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _increaseWidthTo6484; 
		public virtual void increaseWidthTo(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.Layout)) 
				@__env.CallVoidMethod(this, _increaseWidthTo6484, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.text.Layout.staticClass, _increaseWidthTo6484, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAlignment6485; 
		public virtual android.text.Layout.Alignment getAlignment() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.Layout)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.text.Layout.Alignment>(@__env, @__env.CallObjectMethodPtr(this, _getAlignment6485)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.text.Layout.Alignment>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.text.Layout.staticClass, _getAlignment6485)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSpacingMultiplier6486; 
		public virtual float getSpacingMultiplier() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.Layout)) 
				return @__env.CallFloatMethod(this, _getSpacingMultiplier6486); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, android.text.Layout.staticClass, _getSpacingMultiplier6486); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSpacingAdd6487; 
		public virtual float getSpacingAdd() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.Layout)) 
				return @__env.CallFloatMethod(this, _getSpacingAdd6487); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, android.text.Layout.staticClass, _getSpacingAdd6487); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLineTop6488; 
		public abstract int getLineTop(int arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _getLineDescent6489; 
		public abstract int getLineDescent(int arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _getLineStart6490; 
		public abstract int getLineStart(int arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _getParagraphDirection6491; 
		public abstract int getParagraphDirection(int arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _getLineContainsTab6492; 
		public abstract bool getLineContainsTab(int arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _getLineDirections6493; 
		public abstract android.text.Layout.Directions getLineDirections(int arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _getTopPadding6494; 
		public abstract int getTopPadding(); 
		internal static global::net.sf.jni4net.jni.MethodId _getBottomPadding6495; 
		public abstract int getBottomPadding(); 
		internal static global::net.sf.jni4net.jni.MethodId _getPrimaryHorizontal6496; 
		public virtual float getPrimaryHorizontal(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.Layout)) 
				return @__env.CallFloatMethod(this, _getPrimaryHorizontal6496, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, android.text.Layout.staticClass, _getPrimaryHorizontal6496, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSecondaryHorizontal6497; 
		public virtual float getSecondaryHorizontal(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.Layout)) 
				return @__env.CallFloatMethod(this, _getSecondaryHorizontal6497, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, android.text.Layout.staticClass, _getSecondaryHorizontal6497, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLineLeft6498; 
		public virtual float getLineLeft(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.Layout)) 
				return @__env.CallFloatMethod(this, _getLineLeft6498, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, android.text.Layout.staticClass, _getLineLeft6498, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLineRight6499; 
		public virtual float getLineRight(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.Layout)) 
				return @__env.CallFloatMethod(this, _getLineRight6499, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, android.text.Layout.staticClass, _getLineRight6499, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLineMax6500; 
		public virtual float getLineMax(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.Layout)) 
				return @__env.CallFloatMethod(this, _getLineMax6500, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, android.text.Layout.staticClass, _getLineMax6500, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLineForVertical6501; 
		public virtual int getLineForVertical(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.Layout)) 
				return @__env.CallIntMethod(this, _getLineForVertical6501, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.text.Layout.staticClass, _getLineForVertical6501, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLineForOffset6502; 
		public virtual int getLineForOffset(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.Layout)) 
				return @__env.CallIntMethod(this, _getLineForOffset6502, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.text.Layout.staticClass, _getLineForOffset6502, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getOffsetForHorizontal6503; 
		public virtual int getOffsetForHorizontal(int arg0, float arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.Layout)) 
				return @__env.CallIntMethod(this, _getOffsetForHorizontal6503, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.text.Layout.staticClass, _getOffsetForHorizontal6503, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLineEnd6504; 
		public virtual int getLineEnd(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.Layout)) 
				return @__env.CallIntMethod(this, _getLineEnd6504, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.text.Layout.staticClass, _getLineEnd6504, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLineVisibleEnd6505; 
		public virtual int getLineVisibleEnd(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.Layout)) 
				return @__env.CallIntMethod(this, _getLineVisibleEnd6505, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.text.Layout.staticClass, _getLineVisibleEnd6505, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLineBottom6506; 
		public virtual int getLineBottom(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.Layout)) 
				return @__env.CallIntMethod(this, _getLineBottom6506, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.text.Layout.staticClass, _getLineBottom6506, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLineBaseline6507; 
		public virtual int getLineBaseline(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.Layout)) 
				return @__env.CallIntMethod(this, _getLineBaseline6507, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.text.Layout.staticClass, _getLineBaseline6507, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLineAscent6508; 
		public virtual int getLineAscent(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.Layout)) 
				return @__env.CallIntMethod(this, _getLineAscent6508, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.text.Layout.staticClass, _getLineAscent6508, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getOffsetToLeftOf6509; 
		public virtual int getOffsetToLeftOf(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.Layout)) 
				return @__env.CallIntMethod(this, _getOffsetToLeftOf6509, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.text.Layout.staticClass, _getOffsetToLeftOf6509, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getOffsetToRightOf6510; 
		public virtual int getOffsetToRightOf(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.Layout)) 
				return @__env.CallIntMethod(this, _getOffsetToRightOf6510, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.text.Layout.staticClass, _getOffsetToRightOf6510, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCursorPath6511; 
		public virtual void getCursorPath(int arg0, android.graphics.Path arg1, java.lang.CharSequence arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.Layout)) 
				@__env.CallVoidMethod(this, _getCursorPath6511, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.text.Layout.staticClass, _getCursorPath6511, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSelectionPath6512; 
		public virtual void getSelectionPath(int arg0, int arg1, android.graphics.Path arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.Layout)) 
				@__env.CallVoidMethod(this, _getSelectionPath6512, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.text.Layout.staticClass, _getSelectionPath6512, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getParagraphAlignment6513; 
		public virtual android.text.Layout.Alignment getParagraphAlignment(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.Layout)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.text.Layout.Alignment>(@__env, @__env.CallObjectMethodPtr(this, _getParagraphAlignment6513, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.text.Layout.Alignment>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.text.Layout.staticClass, _getParagraphAlignment6513, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getParagraphLeft6514; 
		public virtual int getParagraphLeft(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.Layout)) 
				return @__env.CallIntMethod(this, _getParagraphLeft6514, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.text.Layout.staticClass, _getParagraphLeft6514, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getParagraphRight6515; 
		public virtual int getParagraphRight(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.Layout)) 
				return @__env.CallIntMethod(this, _getParagraphRight6515, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.text.Layout.staticClass, _getParagraphRight6515, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isSpanned6516; 
		protected virtual bool isSpanned() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.Layout)) 
				return @__env.CallBooleanMethod(this, _isSpanned6516); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.text.Layout.staticClass, _isSpanned6516); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getEllipsisStart6517; 
		public abstract int getEllipsisStart(int arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _getEllipsisCount6518; 
		public abstract int getEllipsisCount(int arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _Layout6519; 
		protected Layout(java.lang.CharSequence arg0, android.text.TextPaint arg1, int arg2, android.text.Layout.Alignment arg3, float arg4, float arg5)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.text.Layout.staticClass, _Layout6519, this, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5)); 
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
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.text.Layout.staticClass = @__class; 
			global::android.text.Layout._getLineWidth6472 = @__env.GetMethodID(global::android.text.Layout.staticClass, "getLineWidth", "(I)F"); 
			global::android.text.Layout._getText6473 = @__env.GetMethodID(global::android.text.Layout.staticClass, "getText", "()Ljava/lang/CharSequence;"); 
			global::android.text.Layout._draw6474 = @__env.GetMethodID(global::android.text.Layout.staticClass, "draw", "(Landroid/graphics/Canvas;)V"); 
			global::android.text.Layout._draw6475 = @__env.GetMethodID(global::android.text.Layout.staticClass, "draw", "(Landroid/graphics/Canvas;Landroid/graphics/Path;Landroid/graphics/Paint;I)V"); 
			global::android.text.Layout._getWidth6476 = @__env.GetMethodID(global::android.text.Layout.staticClass, "getWidth", "()I"); 
			global::android.text.Layout._getHeight6477 = @__env.GetMethodID(global::android.text.Layout.staticClass, "getHeight", "()I"); 
			global::android.text.Layout._getPaint6478 = @__env.GetMethodID(global::android.text.Layout.staticClass, "getPaint", "()Landroid/text/TextPaint;"); 
			global::android.text.Layout._getLineCount6479 = @__env.GetMethodID(global::android.text.Layout.staticClass, "getLineCount", "()I"); 
			global::android.text.Layout._getLineBounds6480 = @__env.GetMethodID(global::android.text.Layout.staticClass, "getLineBounds", "(ILandroid/graphics/Rect;)I"); 
			global::android.text.Layout._getDesiredWidth6481 = @__env.GetStaticMethodID(global::android.text.Layout.staticClass, "getDesiredWidth", "(Ljava/lang/CharSequence;IILandroid/text/TextPaint;)F"); 
			global::android.text.Layout._getDesiredWidth6482 = @__env.GetStaticMethodID(global::android.text.Layout.staticClass, "getDesiredWidth", "(Ljava/lang/CharSequence;Landroid/text/TextPaint;)F"); 
			global::android.text.Layout._getEllipsizedWidth6483 = @__env.GetMethodID(global::android.text.Layout.staticClass, "getEllipsizedWidth", "()I"); 
			global::android.text.Layout._increaseWidthTo6484 = @__env.GetMethodID(global::android.text.Layout.staticClass, "increaseWidthTo", "(I)V"); 
			global::android.text.Layout._getAlignment6485 = @__env.GetMethodID(global::android.text.Layout.staticClass, "getAlignment", "()Landroid/text/Layout$Alignment;"); 
			global::android.text.Layout._getSpacingMultiplier6486 = @__env.GetMethodID(global::android.text.Layout.staticClass, "getSpacingMultiplier", "()F"); 
			global::android.text.Layout._getSpacingAdd6487 = @__env.GetMethodID(global::android.text.Layout.staticClass, "getSpacingAdd", "()F"); 
			global::android.text.Layout._getLineTop6488 = @__env.GetMethodID(global::android.text.Layout.staticClass, "getLineTop", "(I)I"); 
			global::android.text.Layout._getLineDescent6489 = @__env.GetMethodID(global::android.text.Layout.staticClass, "getLineDescent", "(I)I"); 
			global::android.text.Layout._getLineStart6490 = @__env.GetMethodID(global::android.text.Layout.staticClass, "getLineStart", "(I)I"); 
			global::android.text.Layout._getParagraphDirection6491 = @__env.GetMethodID(global::android.text.Layout.staticClass, "getParagraphDirection", "(I)I"); 
			global::android.text.Layout._getLineContainsTab6492 = @__env.GetMethodID(global::android.text.Layout.staticClass, "getLineContainsTab", "(I)Z"); 
			global::android.text.Layout._getLineDirections6493 = @__env.GetMethodID(global::android.text.Layout.staticClass, "getLineDirections", "(I)Landroid/text/Layout$Directions;"); 
			global::android.text.Layout._getTopPadding6494 = @__env.GetMethodID(global::android.text.Layout.staticClass, "getTopPadding", "()I"); 
			global::android.text.Layout._getBottomPadding6495 = @__env.GetMethodID(global::android.text.Layout.staticClass, "getBottomPadding", "()I"); 
			global::android.text.Layout._getPrimaryHorizontal6496 = @__env.GetMethodID(global::android.text.Layout.staticClass, "getPrimaryHorizontal", "(I)F"); 
			global::android.text.Layout._getSecondaryHorizontal6497 = @__env.GetMethodID(global::android.text.Layout.staticClass, "getSecondaryHorizontal", "(I)F"); 
			global::android.text.Layout._getLineLeft6498 = @__env.GetMethodID(global::android.text.Layout.staticClass, "getLineLeft", "(I)F"); 
			global::android.text.Layout._getLineRight6499 = @__env.GetMethodID(global::android.text.Layout.staticClass, "getLineRight", "(I)F"); 
			global::android.text.Layout._getLineMax6500 = @__env.GetMethodID(global::android.text.Layout.staticClass, "getLineMax", "(I)F"); 
			global::android.text.Layout._getLineForVertical6501 = @__env.GetMethodID(global::android.text.Layout.staticClass, "getLineForVertical", "(I)I"); 
			global::android.text.Layout._getLineForOffset6502 = @__env.GetMethodID(global::android.text.Layout.staticClass, "getLineForOffset", "(I)I"); 
			global::android.text.Layout._getOffsetForHorizontal6503 = @__env.GetMethodID(global::android.text.Layout.staticClass, "getOffsetForHorizontal", "(IF)I"); 
			global::android.text.Layout._getLineEnd6504 = @__env.GetMethodID(global::android.text.Layout.staticClass, "getLineEnd", "(I)I"); 
			global::android.text.Layout._getLineVisibleEnd6505 = @__env.GetMethodID(global::android.text.Layout.staticClass, "getLineVisibleEnd", "(I)I"); 
			global::android.text.Layout._getLineBottom6506 = @__env.GetMethodID(global::android.text.Layout.staticClass, "getLineBottom", "(I)I"); 
			global::android.text.Layout._getLineBaseline6507 = @__env.GetMethodID(global::android.text.Layout.staticClass, "getLineBaseline", "(I)I"); 
			global::android.text.Layout._getLineAscent6508 = @__env.GetMethodID(global::android.text.Layout.staticClass, "getLineAscent", "(I)I"); 
			global::android.text.Layout._getOffsetToLeftOf6509 = @__env.GetMethodID(global::android.text.Layout.staticClass, "getOffsetToLeftOf", "(I)I"); 
			global::android.text.Layout._getOffsetToRightOf6510 = @__env.GetMethodID(global::android.text.Layout.staticClass, "getOffsetToRightOf", "(I)I"); 
			global::android.text.Layout._getCursorPath6511 = @__env.GetMethodID(global::android.text.Layout.staticClass, "getCursorPath", "(ILandroid/graphics/Path;Ljava/lang/CharSequence;)V"); 
			global::android.text.Layout._getSelectionPath6512 = @__env.GetMethodID(global::android.text.Layout.staticClass, "getSelectionPath", "(IILandroid/graphics/Path;)V"); 
			global::android.text.Layout._getParagraphAlignment6513 = @__env.GetMethodID(global::android.text.Layout.staticClass, "getParagraphAlignment", "(I)Landroid/text/Layout$Alignment;"); 
			global::android.text.Layout._getParagraphLeft6514 = @__env.GetMethodID(global::android.text.Layout.staticClass, "getParagraphLeft", "(I)I"); 
			global::android.text.Layout._getParagraphRight6515 = @__env.GetMethodID(global::android.text.Layout.staticClass, "getParagraphRight", "(I)I"); 
			global::android.text.Layout._isSpanned6516 = @__env.GetMethodID(global::android.text.Layout.staticClass, "isSpanned", "()Z"); 
			global::android.text.Layout._getEllipsisStart6517 = @__env.GetMethodID(global::android.text.Layout.staticClass, "getEllipsisStart", "(I)I"); 
			global::android.text.Layout._getEllipsisCount6518 = @__env.GetMethodID(global::android.text.Layout.staticClass, "getEllipsisCount", "(I)I"); 
			global::android.text.Layout._Layout6519 = @__env.GetMethodID(global::android.text.Layout.staticClass, "<init>", "(Ljava/lang/CharSequence;Landroid/text/TextPaint;ILandroid/text/Layout$Alignment;FF)V"); 
		} 
	} 
} 
