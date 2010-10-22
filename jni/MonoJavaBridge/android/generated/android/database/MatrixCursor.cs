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
			internal static global::MonoJavaBridge.MethodId _add4645;
			public virtual global::android.database.MatrixCursor.RowBuilder add(java.lang.Object arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.database.MatrixCursor.RowBuilder._add4645, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.database.MatrixCursor.RowBuilder;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.database.MatrixCursor.RowBuilder.staticClass, global::android.database.MatrixCursor.RowBuilder._add4645, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.database.MatrixCursor.RowBuilder;
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.database.MatrixCursor.RowBuilder.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/MatrixCursor$RowBuilder"));
				global::android.database.MatrixCursor.RowBuilder._add4645 = @__env.GetMethodIDNoThrow(global::android.database.MatrixCursor.RowBuilder.staticClass, "add", "(Ljava/lang/Object;)Landroid/database/MatrixCursor$RowBuilder;");
			}
		}
		internal static global::MonoJavaBridge.MethodId _getShort4646;
		public override short getShort(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::android.database.MatrixCursor._getShort4646, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::android.database.MatrixCursor.staticClass, global::android.database.MatrixCursor._getShort4646, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getInt4647;
		public override int getInt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.database.MatrixCursor._getInt4647, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.database.MatrixCursor.staticClass, global::android.database.MatrixCursor._getInt4647, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLong4648;
		public override long getLong(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.database.MatrixCursor._getLong4648, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.database.MatrixCursor.staticClass, global::android.database.MatrixCursor._getLong4648, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFloat4649;
		public override float getFloat(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.database.MatrixCursor._getFloat4649, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.database.MatrixCursor.staticClass, global::android.database.MatrixCursor._getFloat4649, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDouble4650;
		public override double getDouble(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::android.database.MatrixCursor._getDouble4650, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::android.database.MatrixCursor.staticClass, global::android.database.MatrixCursor._getDouble4650, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getString4651;
		public override global::java.lang.String getString(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.database.MatrixCursor._getString4651, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.database.MatrixCursor.staticClass, global::android.database.MatrixCursor._getString4651, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		public new int Count
		{
			get
			{
				return getCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCount4652;
		public override int getCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.database.MatrixCursor._getCount4652);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.database.MatrixCursor.staticClass, global::android.database.MatrixCursor._getCount4652);
		}
		public new global::java.lang.String[] ColumnNames
		{
			get
			{
				return getColumnNames();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getColumnNames4653;
		public override global::java.lang.String[] getColumnNames() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.database.MatrixCursor._getColumnNames4653)) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.database.MatrixCursor.staticClass, global::android.database.MatrixCursor._getColumnNames4653)) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _isNull4654;
		public override bool isNull(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.MatrixCursor._isNull4654, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.MatrixCursor.staticClass, global::android.database.MatrixCursor._isNull4654, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _newRow4655;
		public virtual global::android.database.MatrixCursor.RowBuilder newRow() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.database.MatrixCursor._newRow4655)) as android.database.MatrixCursor.RowBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.database.MatrixCursor.staticClass, global::android.database.MatrixCursor._newRow4655)) as android.database.MatrixCursor.RowBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _addRow4656;
		public virtual void addRow(java.lang.Iterable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.MatrixCursor._addRow4656, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.MatrixCursor.staticClass, global::android.database.MatrixCursor._addRow4656, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addRow4657;
		public virtual void addRow(java.lang.Object[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.MatrixCursor._addRow4657, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.MatrixCursor.staticClass, global::android.database.MatrixCursor._addRow4657, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _MatrixCursor4658;
		public MatrixCursor(java.lang.String[] arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.database.MatrixCursor.staticClass, global::android.database.MatrixCursor._MatrixCursor4658, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _MatrixCursor4659;
		public MatrixCursor(java.lang.String[] arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.database.MatrixCursor.staticClass, global::android.database.MatrixCursor._MatrixCursor4659, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.database.MatrixCursor.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/MatrixCursor"));
			global::android.database.MatrixCursor._getShort4646 = @__env.GetMethodIDNoThrow(global::android.database.MatrixCursor.staticClass, "getShort", "(I)S");
			global::android.database.MatrixCursor._getInt4647 = @__env.GetMethodIDNoThrow(global::android.database.MatrixCursor.staticClass, "getInt", "(I)I");
			global::android.database.MatrixCursor._getLong4648 = @__env.GetMethodIDNoThrow(global::android.database.MatrixCursor.staticClass, "getLong", "(I)J");
			global::android.database.MatrixCursor._getFloat4649 = @__env.GetMethodIDNoThrow(global::android.database.MatrixCursor.staticClass, "getFloat", "(I)F");
			global::android.database.MatrixCursor._getDouble4650 = @__env.GetMethodIDNoThrow(global::android.database.MatrixCursor.staticClass, "getDouble", "(I)D");
			global::android.database.MatrixCursor._getString4651 = @__env.GetMethodIDNoThrow(global::android.database.MatrixCursor.staticClass, "getString", "(I)Ljava/lang/String;");
			global::android.database.MatrixCursor._getCount4652 = @__env.GetMethodIDNoThrow(global::android.database.MatrixCursor.staticClass, "getCount", "()I");
			global::android.database.MatrixCursor._getColumnNames4653 = @__env.GetMethodIDNoThrow(global::android.database.MatrixCursor.staticClass, "getColumnNames", "()[Ljava/lang/String;");
			global::android.database.MatrixCursor._isNull4654 = @__env.GetMethodIDNoThrow(global::android.database.MatrixCursor.staticClass, "isNull", "(I)Z");
			global::android.database.MatrixCursor._newRow4655 = @__env.GetMethodIDNoThrow(global::android.database.MatrixCursor.staticClass, "newRow", "()Landroid/database/MatrixCursor$RowBuilder;");
			global::android.database.MatrixCursor._addRow4656 = @__env.GetMethodIDNoThrow(global::android.database.MatrixCursor.staticClass, "addRow", "(Ljava/lang/Iterable;)V");
			global::android.database.MatrixCursor._addRow4657 = @__env.GetMethodIDNoThrow(global::android.database.MatrixCursor.staticClass, "addRow", "([Ljava/lang/Object;)V");
			global::android.database.MatrixCursor._MatrixCursor4658 = @__env.GetMethodIDNoThrow(global::android.database.MatrixCursor.staticClass, "<init>", "([Ljava/lang/String;)V");
			global::android.database.MatrixCursor._MatrixCursor4659 = @__env.GetMethodIDNoThrow(global::android.database.MatrixCursor.staticClass, "<init>", "([Ljava/lang/String;I)V");
		}
	}
}
