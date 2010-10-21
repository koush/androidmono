namespace android.text
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Selection : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Selection()
		{
			InitJNI();
		}
		protected Selection(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _selectAll12845;
		public static void selectAll(android.text.Spannable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.text.Selection.staticClass, global::android.text.Selection._selectAll12845, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSelection12846;
		public static void setSelection(android.text.Spannable arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.text.Selection.staticClass, global::android.text.Selection._setSelection12846, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setSelection12847;
		public static void setSelection(android.text.Spannable arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.text.Selection.staticClass, global::android.text.Selection._setSelection12847, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getSelectionStart12848;
		public static int getSelectionStart(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.text.Selection.staticClass, global::android.text.Selection._getSelectionStart12848, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getSelectionEnd12849;
		public static int getSelectionEnd(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.text.Selection.staticClass, global::android.text.Selection._getSelectionEnd12849, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _extendSelection12850;
		public static void extendSelection(android.text.Spannable arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.text.Selection.staticClass, global::android.text.Selection._extendSelection12850, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _removeSelection12851;
		public static void removeSelection(android.text.Spannable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.text.Selection.staticClass, global::android.text.Selection._removeSelection12851, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _moveUp12852;
		public static bool moveUp(android.text.Spannable arg0, android.text.Layout arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.text.Selection.staticClass, global::android.text.Selection._moveUp12852, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _moveDown12853;
		public static bool moveDown(android.text.Spannable arg0, android.text.Layout arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.text.Selection.staticClass, global::android.text.Selection._moveDown12853, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _moveLeft12854;
		public static bool moveLeft(android.text.Spannable arg0, android.text.Layout arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.text.Selection.staticClass, global::android.text.Selection._moveLeft12854, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _moveRight12855;
		public static bool moveRight(android.text.Spannable arg0, android.text.Layout arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.text.Selection.staticClass, global::android.text.Selection._moveRight12855, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _extendUp12856;
		public static bool extendUp(android.text.Spannable arg0, android.text.Layout arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.text.Selection.staticClass, global::android.text.Selection._extendUp12856, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _extendDown12857;
		public static bool extendDown(android.text.Spannable arg0, android.text.Layout arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.text.Selection.staticClass, global::android.text.Selection._extendDown12857, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _extendLeft12858;
		public static bool extendLeft(android.text.Spannable arg0, android.text.Layout arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.text.Selection.staticClass, global::android.text.Selection._extendLeft12858, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _extendRight12859;
		public static bool extendRight(android.text.Spannable arg0, android.text.Layout arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.text.Selection.staticClass, global::android.text.Selection._extendRight12859, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _extendToLeftEdge12860;
		public static bool extendToLeftEdge(android.text.Spannable arg0, android.text.Layout arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.text.Selection.staticClass, global::android.text.Selection._extendToLeftEdge12860, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _extendToRightEdge12861;
		public static bool extendToRightEdge(android.text.Spannable arg0, android.text.Layout arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.text.Selection.staticClass, global::android.text.Selection._extendToRightEdge12861, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _moveToLeftEdge12862;
		public static bool moveToLeftEdge(android.text.Spannable arg0, android.text.Layout arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.text.Selection.staticClass, global::android.text.Selection._moveToLeftEdge12862, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _moveToRightEdge12863;
		public static bool moveToRightEdge(android.text.Spannable arg0, android.text.Layout arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.text.Selection.staticClass, global::android.text.Selection._moveToRightEdge12863, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.FieldId _SELECTION_START12864;
		public static global::java.lang.Object SELECTION_START
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.text.Selection.staticClass, _SELECTION_START12864)) as java.lang.Object;
			}
		}
		internal static global::MonoJavaBridge.FieldId _SELECTION_END12865;
		public static global::java.lang.Object SELECTION_END
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.text.Selection.staticClass, _SELECTION_END12865)) as java.lang.Object;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.Selection.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/Selection"));
			global::android.text.Selection._selectAll12845 = @__env.GetStaticMethodIDNoThrow(global::android.text.Selection.staticClass, "selectAll", "(Landroid/text/Spannable;)V");
			global::android.text.Selection._setSelection12846 = @__env.GetStaticMethodIDNoThrow(global::android.text.Selection.staticClass, "setSelection", "(Landroid/text/Spannable;II)V");
			global::android.text.Selection._setSelection12847 = @__env.GetStaticMethodIDNoThrow(global::android.text.Selection.staticClass, "setSelection", "(Landroid/text/Spannable;I)V");
			global::android.text.Selection._getSelectionStart12848 = @__env.GetStaticMethodIDNoThrow(global::android.text.Selection.staticClass, "getSelectionStart", "(Ljava/lang/CharSequence;)I");
			global::android.text.Selection._getSelectionEnd12849 = @__env.GetStaticMethodIDNoThrow(global::android.text.Selection.staticClass, "getSelectionEnd", "(Ljava/lang/CharSequence;)I");
			global::android.text.Selection._extendSelection12850 = @__env.GetStaticMethodIDNoThrow(global::android.text.Selection.staticClass, "extendSelection", "(Landroid/text/Spannable;I)V");
			global::android.text.Selection._removeSelection12851 = @__env.GetStaticMethodIDNoThrow(global::android.text.Selection.staticClass, "removeSelection", "(Landroid/text/Spannable;)V");
			global::android.text.Selection._moveUp12852 = @__env.GetStaticMethodIDNoThrow(global::android.text.Selection.staticClass, "moveUp", "(Landroid/text/Spannable;Landroid/text/Layout;)Z");
			global::android.text.Selection._moveDown12853 = @__env.GetStaticMethodIDNoThrow(global::android.text.Selection.staticClass, "moveDown", "(Landroid/text/Spannable;Landroid/text/Layout;)Z");
			global::android.text.Selection._moveLeft12854 = @__env.GetStaticMethodIDNoThrow(global::android.text.Selection.staticClass, "moveLeft", "(Landroid/text/Spannable;Landroid/text/Layout;)Z");
			global::android.text.Selection._moveRight12855 = @__env.GetStaticMethodIDNoThrow(global::android.text.Selection.staticClass, "moveRight", "(Landroid/text/Spannable;Landroid/text/Layout;)Z");
			global::android.text.Selection._extendUp12856 = @__env.GetStaticMethodIDNoThrow(global::android.text.Selection.staticClass, "extendUp", "(Landroid/text/Spannable;Landroid/text/Layout;)Z");
			global::android.text.Selection._extendDown12857 = @__env.GetStaticMethodIDNoThrow(global::android.text.Selection.staticClass, "extendDown", "(Landroid/text/Spannable;Landroid/text/Layout;)Z");
			global::android.text.Selection._extendLeft12858 = @__env.GetStaticMethodIDNoThrow(global::android.text.Selection.staticClass, "extendLeft", "(Landroid/text/Spannable;Landroid/text/Layout;)Z");
			global::android.text.Selection._extendRight12859 = @__env.GetStaticMethodIDNoThrow(global::android.text.Selection.staticClass, "extendRight", "(Landroid/text/Spannable;Landroid/text/Layout;)Z");
			global::android.text.Selection._extendToLeftEdge12860 = @__env.GetStaticMethodIDNoThrow(global::android.text.Selection.staticClass, "extendToLeftEdge", "(Landroid/text/Spannable;Landroid/text/Layout;)Z");
			global::android.text.Selection._extendToRightEdge12861 = @__env.GetStaticMethodIDNoThrow(global::android.text.Selection.staticClass, "extendToRightEdge", "(Landroid/text/Spannable;Landroid/text/Layout;)Z");
			global::android.text.Selection._moveToLeftEdge12862 = @__env.GetStaticMethodIDNoThrow(global::android.text.Selection.staticClass, "moveToLeftEdge", "(Landroid/text/Spannable;Landroid/text/Layout;)Z");
			global::android.text.Selection._moveToRightEdge12863 = @__env.GetStaticMethodIDNoThrow(global::android.text.Selection.staticClass, "moveToRightEdge", "(Landroid/text/Spannable;Landroid/text/Layout;)Z");
			global::android.text.Selection._SELECTION_START12864 = @__env.GetStaticFieldIDNoThrow(global::android.text.Selection.staticClass, "SELECTION_START", "Ljava/lang/Object;");
			global::android.text.Selection._SELECTION_END12865 = @__env.GetStaticFieldIDNoThrow(global::android.text.Selection.staticClass, "SELECTION_END", "Ljava/lang/Object;");
		}
	}
}
