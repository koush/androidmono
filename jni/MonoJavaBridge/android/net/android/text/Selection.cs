namespace android.text 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class Selection : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static Selection() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.text.Selection), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.text.Selection(@__env); 
			} 
		} 
		protected Selection(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _selectAll6535; 
		public static void selectAll(android.text.Spannable arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.text.Selection.staticClass, _selectAll6535, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSelection6536; 
		public static void setSelection(android.text.Spannable arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.text.Selection.staticClass, _setSelection6536, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSelection6537; 
		public static void setSelection(android.text.Spannable arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.text.Selection.staticClass, _setSelection6537, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSelectionStart6538; 
		public static int getSelectionStart(java.lang.CharSequence arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.text.Selection.staticClass, _getSelectionStart6538, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSelectionEnd6539; 
		public static int getSelectionEnd(java.lang.CharSequence arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.text.Selection.staticClass, _getSelectionEnd6539, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _extendSelection6540; 
		public static void extendSelection(android.text.Spannable arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.text.Selection.staticClass, _extendSelection6540, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _removeSelection6541; 
		public static void removeSelection(android.text.Spannable arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.text.Selection.staticClass, _removeSelection6541, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _moveUp6542; 
		public static bool moveUp(android.text.Spannable arg0, android.text.Layout arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticBooleanMethod(android.text.Selection.staticClass, _moveUp6542, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _moveDown6543; 
		public static bool moveDown(android.text.Spannable arg0, android.text.Layout arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticBooleanMethod(android.text.Selection.staticClass, _moveDown6543, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _moveLeft6544; 
		public static bool moveLeft(android.text.Spannable arg0, android.text.Layout arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticBooleanMethod(android.text.Selection.staticClass, _moveLeft6544, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _moveRight6545; 
		public static bool moveRight(android.text.Spannable arg0, android.text.Layout arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticBooleanMethod(android.text.Selection.staticClass, _moveRight6545, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _extendUp6546; 
		public static bool extendUp(android.text.Spannable arg0, android.text.Layout arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticBooleanMethod(android.text.Selection.staticClass, _extendUp6546, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _extendDown6547; 
		public static bool extendDown(android.text.Spannable arg0, android.text.Layout arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticBooleanMethod(android.text.Selection.staticClass, _extendDown6547, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _extendLeft6548; 
		public static bool extendLeft(android.text.Spannable arg0, android.text.Layout arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticBooleanMethod(android.text.Selection.staticClass, _extendLeft6548, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _extendRight6549; 
		public static bool extendRight(android.text.Spannable arg0, android.text.Layout arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticBooleanMethod(android.text.Selection.staticClass, _extendRight6549, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _extendToLeftEdge6550; 
		public static bool extendToLeftEdge(android.text.Spannable arg0, android.text.Layout arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticBooleanMethod(android.text.Selection.staticClass, _extendToLeftEdge6550, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _extendToRightEdge6551; 
		public static bool extendToRightEdge(android.text.Spannable arg0, android.text.Layout arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticBooleanMethod(android.text.Selection.staticClass, _extendToRightEdge6551, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _moveToLeftEdge6552; 
		public static bool moveToLeftEdge(android.text.Spannable arg0, android.text.Layout arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticBooleanMethod(android.text.Selection.staticClass, _moveToLeftEdge6552, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _moveToRightEdge6553; 
		public static bool moveToRightEdge(android.text.Spannable arg0, android.text.Layout arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticBooleanMethod(android.text.Selection.staticClass, _moveToRightEdge6553, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _SELECTION_START6554; 
		public static java.lang.Object SELECTION_START
		{ 
			get 
			{ 
				return default(java.lang.Object); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _SELECTION_END6555; 
		public static java.lang.Object SELECTION_END
		{ 
			get 
			{ 
				return default(java.lang.Object); 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.text.Selection.staticClass = @__class; 
			global::android.text.Selection._selectAll6535 = @__env.GetStaticMethodID(global::android.text.Selection.staticClass, "selectAll", "(Landroid/text/Spannable;)V"); 
			global::android.text.Selection._setSelection6536 = @__env.GetStaticMethodID(global::android.text.Selection.staticClass, "setSelection", "(Landroid/text/Spannable;II)V"); 
			global::android.text.Selection._setSelection6537 = @__env.GetStaticMethodID(global::android.text.Selection.staticClass, "setSelection", "(Landroid/text/Spannable;I)V"); 
			global::android.text.Selection._getSelectionStart6538 = @__env.GetStaticMethodID(global::android.text.Selection.staticClass, "getSelectionStart", "(Ljava/lang/CharSequence;)I"); 
			global::android.text.Selection._getSelectionEnd6539 = @__env.GetStaticMethodID(global::android.text.Selection.staticClass, "getSelectionEnd", "(Ljava/lang/CharSequence;)I"); 
			global::android.text.Selection._extendSelection6540 = @__env.GetStaticMethodID(global::android.text.Selection.staticClass, "extendSelection", "(Landroid/text/Spannable;I)V"); 
			global::android.text.Selection._removeSelection6541 = @__env.GetStaticMethodID(global::android.text.Selection.staticClass, "removeSelection", "(Landroid/text/Spannable;)V"); 
			global::android.text.Selection._moveUp6542 = @__env.GetStaticMethodID(global::android.text.Selection.staticClass, "moveUp", "(Landroid/text/Spannable;Landroid/text/Layout;)Z"); 
			global::android.text.Selection._moveDown6543 = @__env.GetStaticMethodID(global::android.text.Selection.staticClass, "moveDown", "(Landroid/text/Spannable;Landroid/text/Layout;)Z"); 
			global::android.text.Selection._moveLeft6544 = @__env.GetStaticMethodID(global::android.text.Selection.staticClass, "moveLeft", "(Landroid/text/Spannable;Landroid/text/Layout;)Z"); 
			global::android.text.Selection._moveRight6545 = @__env.GetStaticMethodID(global::android.text.Selection.staticClass, "moveRight", "(Landroid/text/Spannable;Landroid/text/Layout;)Z"); 
			global::android.text.Selection._extendUp6546 = @__env.GetStaticMethodID(global::android.text.Selection.staticClass, "extendUp", "(Landroid/text/Spannable;Landroid/text/Layout;)Z"); 
			global::android.text.Selection._extendDown6547 = @__env.GetStaticMethodID(global::android.text.Selection.staticClass, "extendDown", "(Landroid/text/Spannable;Landroid/text/Layout;)Z"); 
			global::android.text.Selection._extendLeft6548 = @__env.GetStaticMethodID(global::android.text.Selection.staticClass, "extendLeft", "(Landroid/text/Spannable;Landroid/text/Layout;)Z"); 
			global::android.text.Selection._extendRight6549 = @__env.GetStaticMethodID(global::android.text.Selection.staticClass, "extendRight", "(Landroid/text/Spannable;Landroid/text/Layout;)Z"); 
			global::android.text.Selection._extendToLeftEdge6550 = @__env.GetStaticMethodID(global::android.text.Selection.staticClass, "extendToLeftEdge", "(Landroid/text/Spannable;Landroid/text/Layout;)Z"); 
			global::android.text.Selection._extendToRightEdge6551 = @__env.GetStaticMethodID(global::android.text.Selection.staticClass, "extendToRightEdge", "(Landroid/text/Spannable;Landroid/text/Layout;)Z"); 
			global::android.text.Selection._moveToLeftEdge6552 = @__env.GetStaticMethodID(global::android.text.Selection.staticClass, "moveToLeftEdge", "(Landroid/text/Spannable;Landroid/text/Layout;)Z"); 
			global::android.text.Selection._moveToRightEdge6553 = @__env.GetStaticMethodID(global::android.text.Selection.staticClass, "moveToRightEdge", "(Landroid/text/Spannable;Landroid/text/Layout;)Z"); 
		} 
	} 
} 
