namespace android.text
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Selection : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Selection(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _selectAll12906;
		public static void selectAll(android.text.Spannable arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.Selection._selectAll12906.native == global::System.IntPtr.Zero)
				global::android.text.Selection._selectAll12906 = @__env.GetStaticMethodIDNoThrow(global::android.text.Selection.staticClass, "selectAll", "(Landroid/text/Spannable;)V");
			@__env.CallStaticVoidMethod(android.text.Selection.staticClass, global::android.text.Selection._selectAll12906, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSelection12907;
		public static void setSelection(android.text.Spannable arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.Selection._setSelection12907.native == global::System.IntPtr.Zero)
				global::android.text.Selection._setSelection12907 = @__env.GetStaticMethodIDNoThrow(global::android.text.Selection.staticClass, "setSelection", "(Landroid/text/Spannable;II)V");
			@__env.CallStaticVoidMethod(android.text.Selection.staticClass, global::android.text.Selection._setSelection12907, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setSelection12908;
		public static void setSelection(android.text.Spannable arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.Selection._setSelection12908.native == global::System.IntPtr.Zero)
				global::android.text.Selection._setSelection12908 = @__env.GetStaticMethodIDNoThrow(global::android.text.Selection.staticClass, "setSelection", "(Landroid/text/Spannable;I)V");
			@__env.CallStaticVoidMethod(android.text.Selection.staticClass, global::android.text.Selection._setSelection12908, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getSelectionStart12909;
		public static int getSelectionStart(java.lang.CharSequence arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.Selection._getSelectionStart12909.native == global::System.IntPtr.Zero)
				global::android.text.Selection._getSelectionStart12909 = @__env.GetStaticMethodIDNoThrow(global::android.text.Selection.staticClass, "getSelectionStart", "(Ljava/lang/CharSequence;)I");
			return @__env.CallStaticIntMethod(android.text.Selection.staticClass, global::android.text.Selection._getSelectionStart12909, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public static int getSelectionStart(string arg0)
		{
			return getSelectionStart((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _getSelectionEnd12910;
		public static int getSelectionEnd(java.lang.CharSequence arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.Selection._getSelectionEnd12910.native == global::System.IntPtr.Zero)
				global::android.text.Selection._getSelectionEnd12910 = @__env.GetStaticMethodIDNoThrow(global::android.text.Selection.staticClass, "getSelectionEnd", "(Ljava/lang/CharSequence;)I");
			return @__env.CallStaticIntMethod(android.text.Selection.staticClass, global::android.text.Selection._getSelectionEnd12910, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public static int getSelectionEnd(string arg0)
		{
			return getSelectionEnd((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _extendSelection12911;
		public static void extendSelection(android.text.Spannable arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.Selection._extendSelection12911.native == global::System.IntPtr.Zero)
				global::android.text.Selection._extendSelection12911 = @__env.GetStaticMethodIDNoThrow(global::android.text.Selection.staticClass, "extendSelection", "(Landroid/text/Spannable;I)V");
			@__env.CallStaticVoidMethod(android.text.Selection.staticClass, global::android.text.Selection._extendSelection12911, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _removeSelection12912;
		public static void removeSelection(android.text.Spannable arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.Selection._removeSelection12912.native == global::System.IntPtr.Zero)
				global::android.text.Selection._removeSelection12912 = @__env.GetStaticMethodIDNoThrow(global::android.text.Selection.staticClass, "removeSelection", "(Landroid/text/Spannable;)V");
			@__env.CallStaticVoidMethod(android.text.Selection.staticClass, global::android.text.Selection._removeSelection12912, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _moveUp12913;
		public static bool moveUp(android.text.Spannable arg0, android.text.Layout arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.Selection._moveUp12913.native == global::System.IntPtr.Zero)
				global::android.text.Selection._moveUp12913 = @__env.GetStaticMethodIDNoThrow(global::android.text.Selection.staticClass, "moveUp", "(Landroid/text/Spannable;Landroid/text/Layout;)Z");
			return @__env.CallStaticBooleanMethod(android.text.Selection.staticClass, global::android.text.Selection._moveUp12913, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _moveDown12914;
		public static bool moveDown(android.text.Spannable arg0, android.text.Layout arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.Selection._moveDown12914.native == global::System.IntPtr.Zero)
				global::android.text.Selection._moveDown12914 = @__env.GetStaticMethodIDNoThrow(global::android.text.Selection.staticClass, "moveDown", "(Landroid/text/Spannable;Landroid/text/Layout;)Z");
			return @__env.CallStaticBooleanMethod(android.text.Selection.staticClass, global::android.text.Selection._moveDown12914, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _moveLeft12915;
		public static bool moveLeft(android.text.Spannable arg0, android.text.Layout arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.Selection._moveLeft12915.native == global::System.IntPtr.Zero)
				global::android.text.Selection._moveLeft12915 = @__env.GetStaticMethodIDNoThrow(global::android.text.Selection.staticClass, "moveLeft", "(Landroid/text/Spannable;Landroid/text/Layout;)Z");
			return @__env.CallStaticBooleanMethod(android.text.Selection.staticClass, global::android.text.Selection._moveLeft12915, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _moveRight12916;
		public static bool moveRight(android.text.Spannable arg0, android.text.Layout arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.Selection._moveRight12916.native == global::System.IntPtr.Zero)
				global::android.text.Selection._moveRight12916 = @__env.GetStaticMethodIDNoThrow(global::android.text.Selection.staticClass, "moveRight", "(Landroid/text/Spannable;Landroid/text/Layout;)Z");
			return @__env.CallStaticBooleanMethod(android.text.Selection.staticClass, global::android.text.Selection._moveRight12916, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _extendUp12917;
		public static bool extendUp(android.text.Spannable arg0, android.text.Layout arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.Selection._extendUp12917.native == global::System.IntPtr.Zero)
				global::android.text.Selection._extendUp12917 = @__env.GetStaticMethodIDNoThrow(global::android.text.Selection.staticClass, "extendUp", "(Landroid/text/Spannable;Landroid/text/Layout;)Z");
			return @__env.CallStaticBooleanMethod(android.text.Selection.staticClass, global::android.text.Selection._extendUp12917, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _extendDown12918;
		public static bool extendDown(android.text.Spannable arg0, android.text.Layout arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.Selection._extendDown12918.native == global::System.IntPtr.Zero)
				global::android.text.Selection._extendDown12918 = @__env.GetStaticMethodIDNoThrow(global::android.text.Selection.staticClass, "extendDown", "(Landroid/text/Spannable;Landroid/text/Layout;)Z");
			return @__env.CallStaticBooleanMethod(android.text.Selection.staticClass, global::android.text.Selection._extendDown12918, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _extendLeft12919;
		public static bool extendLeft(android.text.Spannable arg0, android.text.Layout arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.Selection._extendLeft12919.native == global::System.IntPtr.Zero)
				global::android.text.Selection._extendLeft12919 = @__env.GetStaticMethodIDNoThrow(global::android.text.Selection.staticClass, "extendLeft", "(Landroid/text/Spannable;Landroid/text/Layout;)Z");
			return @__env.CallStaticBooleanMethod(android.text.Selection.staticClass, global::android.text.Selection._extendLeft12919, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _extendRight12920;
		public static bool extendRight(android.text.Spannable arg0, android.text.Layout arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.Selection._extendRight12920.native == global::System.IntPtr.Zero)
				global::android.text.Selection._extendRight12920 = @__env.GetStaticMethodIDNoThrow(global::android.text.Selection.staticClass, "extendRight", "(Landroid/text/Spannable;Landroid/text/Layout;)Z");
			return @__env.CallStaticBooleanMethod(android.text.Selection.staticClass, global::android.text.Selection._extendRight12920, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _extendToLeftEdge12921;
		public static bool extendToLeftEdge(android.text.Spannable arg0, android.text.Layout arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.Selection._extendToLeftEdge12921.native == global::System.IntPtr.Zero)
				global::android.text.Selection._extendToLeftEdge12921 = @__env.GetStaticMethodIDNoThrow(global::android.text.Selection.staticClass, "extendToLeftEdge", "(Landroid/text/Spannable;Landroid/text/Layout;)Z");
			return @__env.CallStaticBooleanMethod(android.text.Selection.staticClass, global::android.text.Selection._extendToLeftEdge12921, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _extendToRightEdge12922;
		public static bool extendToRightEdge(android.text.Spannable arg0, android.text.Layout arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.Selection._extendToRightEdge12922.native == global::System.IntPtr.Zero)
				global::android.text.Selection._extendToRightEdge12922 = @__env.GetStaticMethodIDNoThrow(global::android.text.Selection.staticClass, "extendToRightEdge", "(Landroid/text/Spannable;Landroid/text/Layout;)Z");
			return @__env.CallStaticBooleanMethod(android.text.Selection.staticClass, global::android.text.Selection._extendToRightEdge12922, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _moveToLeftEdge12923;
		public static bool moveToLeftEdge(android.text.Spannable arg0, android.text.Layout arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.Selection._moveToLeftEdge12923.native == global::System.IntPtr.Zero)
				global::android.text.Selection._moveToLeftEdge12923 = @__env.GetStaticMethodIDNoThrow(global::android.text.Selection.staticClass, "moveToLeftEdge", "(Landroid/text/Spannable;Landroid/text/Layout;)Z");
			return @__env.CallStaticBooleanMethod(android.text.Selection.staticClass, global::android.text.Selection._moveToLeftEdge12923, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _moveToRightEdge12924;
		public static bool moveToRightEdge(android.text.Spannable arg0, android.text.Layout arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.Selection._moveToRightEdge12924.native == global::System.IntPtr.Zero)
				global::android.text.Selection._moveToRightEdge12924 = @__env.GetStaticMethodIDNoThrow(global::android.text.Selection.staticClass, "moveToRightEdge", "(Landroid/text/Spannable;Landroid/text/Layout;)Z");
			return @__env.CallStaticBooleanMethod(android.text.Selection.staticClass, global::android.text.Selection._moveToRightEdge12924, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.FieldId _SELECTION_START12925;
		public static global::java.lang.Object SELECTION_START
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.text.Selection.staticClass, _SELECTION_START12925)) as java.lang.Object;
			}
		}
		internal static global::MonoJavaBridge.FieldId _SELECTION_END12926;
		public static global::java.lang.Object SELECTION_END
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.text.Selection.staticClass, _SELECTION_END12926)) as java.lang.Object;
			}
		}
		static Selection()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.Selection.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/Selection"));
			global::android.text.Selection._SELECTION_START12925 = @__env.GetStaticFieldIDNoThrow(global::android.text.Selection.staticClass, "SELECTION_START", "Ljava/lang/Object;");
			global::android.text.Selection._SELECTION_END12926 = @__env.GetStaticFieldIDNoThrow(global::android.text.Selection.staticClass, "SELECTION_END", "Ljava/lang/Object;");
		}
		internal static void InitJNI()
		{
		}
	}
}
