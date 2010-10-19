namespace android.database
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class MatrixCursor : android.database.AbstractCursor
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static MatrixCursor()
		{
			InitJNI();
		}
		protected MatrixCursor(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class RowBuilder : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static RowBuilder()
			{
				InitJNI();
			}
			protected RowBuilder(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _add2746;
			public virtual global::android.database.MatrixCursor.RowBuilder add(java.lang.Object arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.database.MatrixCursor.RowBuilder._add2746, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.database.MatrixCursor.RowBuilder;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.database.MatrixCursor.RowBuilder.staticClass, global::android.database.MatrixCursor.RowBuilder._add2746, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.database.MatrixCursor.RowBuilder;
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.database.MatrixCursor.RowBuilder.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/MatrixCursor$RowBuilder"));
				global::android.database.MatrixCursor.RowBuilder._add2746 = @__env.GetMethodIDNoThrow(global::android.database.MatrixCursor.RowBuilder.staticClass, "add", "(Ljava/lang/Object;)Landroid/database/MatrixCursor$RowBuilder;");
			}
		}
		internal static global::MonoJavaBridge.MethodId _getShort2747;
		public override short getShort(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::android.database.MatrixCursor._getShort2747, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::android.database.MatrixCursor.staticClass, global::android.database.MatrixCursor._getShort2747, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getInt2748;
		public override int getInt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.database.MatrixCursor._getInt2748, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.database.MatrixCursor.staticClass, global::android.database.MatrixCursor._getInt2748, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLong2749;
		public override long getLong(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.database.MatrixCursor._getLong2749, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.database.MatrixCursor.staticClass, global::android.database.MatrixCursor._getLong2749, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFloat2750;
		public override float getFloat(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.database.MatrixCursor._getFloat2750, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.database.MatrixCursor.staticClass, global::android.database.MatrixCursor._getFloat2750, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDouble2751;
		public override double getDouble(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::android.database.MatrixCursor._getDouble2751, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::android.database.MatrixCursor.staticClass, global::android.database.MatrixCursor._getDouble2751, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getString2752;
		public override global::java.lang.String getString(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.database.MatrixCursor._getString2752, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.database.MatrixCursor.staticClass, global::android.database.MatrixCursor._getString2752, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		public new int Count
		{
			get
			{
				return getCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCount2753;
		public override int getCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.database.MatrixCursor._getCount2753);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.database.MatrixCursor.staticClass, global::android.database.MatrixCursor._getCount2753);
		}
		public new global::java.lang.String[] ColumnNames
		{
			get
			{
				return getColumnNames();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getColumnNames2754;
		public override global::java.lang.String[] getColumnNames() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.database.MatrixCursor._getColumnNames2754)) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.database.MatrixCursor.staticClass, global::android.database.MatrixCursor._getColumnNames2754)) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _isNull2755;
		public override bool isNull(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.MatrixCursor._isNull2755, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.MatrixCursor.staticClass, global::android.database.MatrixCursor._isNull2755, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _newRow2756;
		public virtual global::android.database.MatrixCursor.RowBuilder newRow() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.database.MatrixCursor._newRow2756)) as android.database.MatrixCursor.RowBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.database.MatrixCursor.staticClass, global::android.database.MatrixCursor._newRow2756)) as android.database.MatrixCursor.RowBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _addRow2757;
		public virtual void addRow(java.lang.Iterable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.MatrixCursor._addRow2757, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.MatrixCursor.staticClass, global::android.database.MatrixCursor._addRow2757, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addRow2758;
		public virtual void addRow(java.lang.Object[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.MatrixCursor._addRow2758, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.MatrixCursor.staticClass, global::android.database.MatrixCursor._addRow2758, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _MatrixCursor2759;
		public MatrixCursor(java.lang.String[] arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.database.MatrixCursor.staticClass, global::android.database.MatrixCursor._MatrixCursor2759, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _MatrixCursor2760;
		public MatrixCursor(java.lang.String[] arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.database.MatrixCursor.staticClass, global::android.database.MatrixCursor._MatrixCursor2760, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.database.MatrixCursor.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/MatrixCursor"));
			global::android.database.MatrixCursor._getShort2747 = @__env.GetMethodIDNoThrow(global::android.database.MatrixCursor.staticClass, "getShort", "(I)S");
			global::android.database.MatrixCursor._getInt2748 = @__env.GetMethodIDNoThrow(global::android.database.MatrixCursor.staticClass, "getInt", "(I)I");
			global::android.database.MatrixCursor._getLong2749 = @__env.GetMethodIDNoThrow(global::android.database.MatrixCursor.staticClass, "getLong", "(I)J");
			global::android.database.MatrixCursor._getFloat2750 = @__env.GetMethodIDNoThrow(global::android.database.MatrixCursor.staticClass, "getFloat", "(I)F");
			global::android.database.MatrixCursor._getDouble2751 = @__env.GetMethodIDNoThrow(global::android.database.MatrixCursor.staticClass, "getDouble", "(I)D");
			global::android.database.MatrixCursor._getString2752 = @__env.GetMethodIDNoThrow(global::android.database.MatrixCursor.staticClass, "getString", "(I)Ljava/lang/String;");
			global::android.database.MatrixCursor._getCount2753 = @__env.GetMethodIDNoThrow(global::android.database.MatrixCursor.staticClass, "getCount", "()I");
			global::android.database.MatrixCursor._getColumnNames2754 = @__env.GetMethodIDNoThrow(global::android.database.MatrixCursor.staticClass, "getColumnNames", "()[Ljava/lang/String;");
			global::android.database.MatrixCursor._isNull2755 = @__env.GetMethodIDNoThrow(global::android.database.MatrixCursor.staticClass, "isNull", "(I)Z");
			global::android.database.MatrixCursor._newRow2756 = @__env.GetMethodIDNoThrow(global::android.database.MatrixCursor.staticClass, "newRow", "()Landroid/database/MatrixCursor$RowBuilder;");
			global::android.database.MatrixCursor._addRow2757 = @__env.GetMethodIDNoThrow(global::android.database.MatrixCursor.staticClass, "addRow", "(Ljava/lang/Iterable;)V");
			global::android.database.MatrixCursor._addRow2758 = @__env.GetMethodIDNoThrow(global::android.database.MatrixCursor.staticClass, "addRow", "([Ljava/lang/Object;)V");
			global::android.database.MatrixCursor._MatrixCursor2759 = @__env.GetMethodIDNoThrow(global::android.database.MatrixCursor.staticClass, "<init>", "([Ljava/lang/String;)V");
			global::android.database.MatrixCursor._MatrixCursor2760 = @__env.GetMethodIDNoThrow(global::android.database.MatrixCursor.staticClass, "<init>", "([Ljava/lang/String;I)V");
		}
	}
}
