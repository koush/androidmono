namespace android.text
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Selection : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Selection(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static void selectAll(android.text.Spannable arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.Selection._m0.native == global::System.IntPtr.Zero)
				global::android.text.Selection._m0 = @__env.GetStaticMethodIDNoThrow(global::android.text.Selection.staticClass, "selectAll", "(Landroid/text/Spannable;)V");
			@__env.CallStaticVoidMethod(android.text.Selection.staticClass, global::android.text.Selection._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static void setSelection(android.text.Spannable arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.Selection._m1.native == global::System.IntPtr.Zero)
				global::android.text.Selection._m1 = @__env.GetStaticMethodIDNoThrow(global::android.text.Selection.staticClass, "setSelection", "(Landroid/text/Spannable;II)V");
			@__env.CallStaticVoidMethod(android.text.Selection.staticClass, global::android.text.Selection._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public static void setSelection(android.text.Spannable arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.Selection._m2.native == global::System.IntPtr.Zero)
				global::android.text.Selection._m2 = @__env.GetStaticMethodIDNoThrow(global::android.text.Selection.staticClass, "setSelection", "(Landroid/text/Spannable;I)V");
			@__env.CallStaticVoidMethod(android.text.Selection.staticClass, global::android.text.Selection._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public static int getSelectionStart(java.lang.CharSequence arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.Selection._m3.native == global::System.IntPtr.Zero)
				global::android.text.Selection._m3 = @__env.GetStaticMethodIDNoThrow(global::android.text.Selection.staticClass, "getSelectionStart", "(Ljava/lang/CharSequence;)I");
			return @__env.CallStaticIntMethod(android.text.Selection.staticClass, global::android.text.Selection._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public static int getSelectionStart(string arg0)
		{
			return getSelectionStart((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public static int getSelectionEnd(java.lang.CharSequence arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.Selection._m4.native == global::System.IntPtr.Zero)
				global::android.text.Selection._m4 = @__env.GetStaticMethodIDNoThrow(global::android.text.Selection.staticClass, "getSelectionEnd", "(Ljava/lang/CharSequence;)I");
			return @__env.CallStaticIntMethod(android.text.Selection.staticClass, global::android.text.Selection._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public static int getSelectionEnd(string arg0)
		{
			return getSelectionEnd((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public static void extendSelection(android.text.Spannable arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.Selection._m5.native == global::System.IntPtr.Zero)
				global::android.text.Selection._m5 = @__env.GetStaticMethodIDNoThrow(global::android.text.Selection.staticClass, "extendSelection", "(Landroid/text/Spannable;I)V");
			@__env.CallStaticVoidMethod(android.text.Selection.staticClass, global::android.text.Selection._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public static void removeSelection(android.text.Spannable arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.Selection._m6.native == global::System.IntPtr.Zero)
				global::android.text.Selection._m6 = @__env.GetStaticMethodIDNoThrow(global::android.text.Selection.staticClass, "removeSelection", "(Landroid/text/Spannable;)V");
			@__env.CallStaticVoidMethod(android.text.Selection.staticClass, global::android.text.Selection._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public static bool moveUp(android.text.Spannable arg0, android.text.Layout arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.Selection._m7.native == global::System.IntPtr.Zero)
				global::android.text.Selection._m7 = @__env.GetStaticMethodIDNoThrow(global::android.text.Selection.staticClass, "moveUp", "(Landroid/text/Spannable;Landroid/text/Layout;)Z");
			return @__env.CallStaticBooleanMethod(android.text.Selection.staticClass, global::android.text.Selection._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public static bool moveDown(android.text.Spannable arg0, android.text.Layout arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.Selection._m8.native == global::System.IntPtr.Zero)
				global::android.text.Selection._m8 = @__env.GetStaticMethodIDNoThrow(global::android.text.Selection.staticClass, "moveDown", "(Landroid/text/Spannable;Landroid/text/Layout;)Z");
			return @__env.CallStaticBooleanMethod(android.text.Selection.staticClass, global::android.text.Selection._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public static bool moveLeft(android.text.Spannable arg0, android.text.Layout arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.Selection._m9.native == global::System.IntPtr.Zero)
				global::android.text.Selection._m9 = @__env.GetStaticMethodIDNoThrow(global::android.text.Selection.staticClass, "moveLeft", "(Landroid/text/Spannable;Landroid/text/Layout;)Z");
			return @__env.CallStaticBooleanMethod(android.text.Selection.staticClass, global::android.text.Selection._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public static bool moveRight(android.text.Spannable arg0, android.text.Layout arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.Selection._m10.native == global::System.IntPtr.Zero)
				global::android.text.Selection._m10 = @__env.GetStaticMethodIDNoThrow(global::android.text.Selection.staticClass, "moveRight", "(Landroid/text/Spannable;Landroid/text/Layout;)Z");
			return @__env.CallStaticBooleanMethod(android.text.Selection.staticClass, global::android.text.Selection._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public static bool extendUp(android.text.Spannable arg0, android.text.Layout arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.Selection._m11.native == global::System.IntPtr.Zero)
				global::android.text.Selection._m11 = @__env.GetStaticMethodIDNoThrow(global::android.text.Selection.staticClass, "extendUp", "(Landroid/text/Spannable;Landroid/text/Layout;)Z");
			return @__env.CallStaticBooleanMethod(android.text.Selection.staticClass, global::android.text.Selection._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public static bool extendDown(android.text.Spannable arg0, android.text.Layout arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.Selection._m12.native == global::System.IntPtr.Zero)
				global::android.text.Selection._m12 = @__env.GetStaticMethodIDNoThrow(global::android.text.Selection.staticClass, "extendDown", "(Landroid/text/Spannable;Landroid/text/Layout;)Z");
			return @__env.CallStaticBooleanMethod(android.text.Selection.staticClass, global::android.text.Selection._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public static bool extendLeft(android.text.Spannable arg0, android.text.Layout arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.Selection._m13.native == global::System.IntPtr.Zero)
				global::android.text.Selection._m13 = @__env.GetStaticMethodIDNoThrow(global::android.text.Selection.staticClass, "extendLeft", "(Landroid/text/Spannable;Landroid/text/Layout;)Z");
			return @__env.CallStaticBooleanMethod(android.text.Selection.staticClass, global::android.text.Selection._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public static bool extendRight(android.text.Spannable arg0, android.text.Layout arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.Selection._m14.native == global::System.IntPtr.Zero)
				global::android.text.Selection._m14 = @__env.GetStaticMethodIDNoThrow(global::android.text.Selection.staticClass, "extendRight", "(Landroid/text/Spannable;Landroid/text/Layout;)Z");
			return @__env.CallStaticBooleanMethod(android.text.Selection.staticClass, global::android.text.Selection._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public static bool extendToLeftEdge(android.text.Spannable arg0, android.text.Layout arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.Selection._m15.native == global::System.IntPtr.Zero)
				global::android.text.Selection._m15 = @__env.GetStaticMethodIDNoThrow(global::android.text.Selection.staticClass, "extendToLeftEdge", "(Landroid/text/Spannable;Landroid/text/Layout;)Z");
			return @__env.CallStaticBooleanMethod(android.text.Selection.staticClass, global::android.text.Selection._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public static bool extendToRightEdge(android.text.Spannable arg0, android.text.Layout arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.Selection._m16.native == global::System.IntPtr.Zero)
				global::android.text.Selection._m16 = @__env.GetStaticMethodIDNoThrow(global::android.text.Selection.staticClass, "extendToRightEdge", "(Landroid/text/Spannable;Landroid/text/Layout;)Z");
			return @__env.CallStaticBooleanMethod(android.text.Selection.staticClass, global::android.text.Selection._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public static bool moveToLeftEdge(android.text.Spannable arg0, android.text.Layout arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.Selection._m17.native == global::System.IntPtr.Zero)
				global::android.text.Selection._m17 = @__env.GetStaticMethodIDNoThrow(global::android.text.Selection.staticClass, "moveToLeftEdge", "(Landroid/text/Spannable;Landroid/text/Layout;)Z");
			return @__env.CallStaticBooleanMethod(android.text.Selection.staticClass, global::android.text.Selection._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public static bool moveToRightEdge(android.text.Spannable arg0, android.text.Layout arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.Selection._m18.native == global::System.IntPtr.Zero)
				global::android.text.Selection._m18 = @__env.GetStaticMethodIDNoThrow(global::android.text.Selection.staticClass, "moveToRightEdge", "(Landroid/text/Spannable;Landroid/text/Layout;)Z");
			return @__env.CallStaticBooleanMethod(android.text.Selection.staticClass, global::android.text.Selection._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.FieldId _SELECTION_START5228;
		public static global::java.lang.Object SELECTION_START
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.text.Selection.staticClass, _SELECTION_START5228)) as java.lang.Object;
			}
		}
		internal static global::MonoJavaBridge.FieldId _SELECTION_END5229;
		public static global::java.lang.Object SELECTION_END
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.text.Selection.staticClass, _SELECTION_END5229)) as java.lang.Object;
			}
		}
		static Selection()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.Selection.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/Selection"));
			global::android.text.Selection._SELECTION_START5228 = @__env.GetStaticFieldIDNoThrow(global::android.text.Selection.staticClass, "SELECTION_START", "Ljava/lang/Object;");
			global::android.text.Selection._SELECTION_END5229 = @__env.GetStaticFieldIDNoThrow(global::android.text.Selection.staticClass, "SELECTION_END", "Ljava/lang/Object;");
		}
	}
}
