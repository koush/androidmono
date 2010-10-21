namespace java.sql
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.sql.PreparedStatement_))]
	public interface PreparedStatement : Statement
	{
		void setBoolean(int arg0, bool arg1);
		void setByte(int arg0, byte arg1);
		void setShort(int arg0, short arg1);
		void setInt(int arg0, int arg1);
		void setLong(int arg0, long arg1);
		void setFloat(int arg0, float arg1);
		void setDouble(int arg0, double arg1);
		void setTimestamp(int arg0, java.sql.Timestamp arg1);
		void setTimestamp(int arg0, java.sql.Timestamp arg1, java.util.Calendar arg2);
		void setURL(int arg0, java.net.URL arg1);
		void setTime(int arg0, java.sql.Time arg1, java.util.Calendar arg2);
		void setTime(int arg0, java.sql.Time arg1);
		void setDate(int arg0, java.sql.Date arg1, java.util.Calendar arg2);
		void setDate(int arg0, java.sql.Date arg1);
		bool execute();
		void addBatch();
		void setString(int arg0, java.lang.String arg1);
		void setObject(int arg0, java.lang.Object arg1, int arg2);
		void setObject(int arg0, java.lang.Object arg1, int arg2, int arg3);
		void setObject(int arg0, java.lang.Object arg1);
		global::java.sql.ResultSetMetaData getMetaData();
		void setBytes(int arg0, byte[] arg1);
		void setBinaryStream(int arg0, java.io.InputStream arg1);
		void setBinaryStream(int arg0, java.io.InputStream arg1, int arg2);
		void setBinaryStream(int arg0, java.io.InputStream arg1, long arg2);
		void setNull(int arg0, int arg1, java.lang.String arg2);
		void setNull(int arg0, int arg1);
		void setBigDecimal(int arg0, java.math.BigDecimal arg1);
		void setAsciiStream(int arg0, java.io.InputStream arg1, int arg2);
		void setAsciiStream(int arg0, java.io.InputStream arg1);
		void setAsciiStream(int arg0, java.io.InputStream arg1, long arg2);
		void setCharacterStream(int arg0, java.io.Reader arg1, int arg2);
		void setCharacterStream(int arg0, java.io.Reader arg1, long arg2);
		void setCharacterStream(int arg0, java.io.Reader arg1);
		void setNString(int arg0, java.lang.String arg1);
		void setNCharacterStream(int arg0, java.io.Reader arg1, long arg2);
		void setNCharacterStream(int arg0, java.io.Reader arg1);
		void setNClob(int arg0, java.io.Reader arg1);
		void setNClob(int arg0, java.io.Reader arg1, long arg2);
		void setClob(int arg0, java.sql.Clob arg1);
		void setClob(int arg0, java.io.Reader arg1, long arg2);
		void setClob(int arg0, java.io.Reader arg1);
		void setBlob(int arg0, java.sql.Blob arg1);
		void setBlob(int arg0, java.io.InputStream arg1, long arg2);
		void setBlob(int arg0, java.io.InputStream arg1);
		global::java.sql.ResultSet executeQuery();
		int executeUpdate();
		void setUnicodeStream(int arg0, java.io.InputStream arg1, int arg2);
		void clearParameters();
		void setRef(int arg0, java.sql.Ref arg1);
		void setArray(int arg0, java.sql.Array arg1);
		global::java.sql.ParameterMetaData getParameterMetaData();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.sql.PreparedStatement))]
	public sealed partial class PreparedStatement_ : java.lang.Object, PreparedStatement
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static PreparedStatement_()
		{
			InitJNI();
		}
		internal PreparedStatement_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _setBoolean24543;
		 void java.sql.PreparedStatement.setBoolean(int arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_._setBoolean24543, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._setBoolean24543, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setByte24544;
		 void java.sql.PreparedStatement.setByte(int arg0, byte arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_._setByte24544, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._setByte24544, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setShort24545;
		 void java.sql.PreparedStatement.setShort(int arg0, short arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_._setShort24545, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._setShort24545, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setInt24546;
		 void java.sql.PreparedStatement.setInt(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_._setInt24546, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._setInt24546, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setLong24547;
		 void java.sql.PreparedStatement.setLong(int arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_._setLong24547, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._setLong24547, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setFloat24548;
		 void java.sql.PreparedStatement.setFloat(int arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_._setFloat24548, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._setFloat24548, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setDouble24549;
		 void java.sql.PreparedStatement.setDouble(int arg0, double arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_._setDouble24549, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._setDouble24549, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setTimestamp24550;
		 void java.sql.PreparedStatement.setTimestamp(int arg0, java.sql.Timestamp arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_._setTimestamp24550, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._setTimestamp24550, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setTimestamp24551;
		 void java.sql.PreparedStatement.setTimestamp(int arg0, java.sql.Timestamp arg1, java.util.Calendar arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_._setTimestamp24551, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._setTimestamp24551, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setURL24552;
		 void java.sql.PreparedStatement.setURL(int arg0, java.net.URL arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_._setURL24552, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._setURL24552, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setTime24553;
		 void java.sql.PreparedStatement.setTime(int arg0, java.sql.Time arg1, java.util.Calendar arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_._setTime24553, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._setTime24553, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setTime24554;
		 void java.sql.PreparedStatement.setTime(int arg0, java.sql.Time arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_._setTime24554, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._setTime24554, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setDate24555;
		 void java.sql.PreparedStatement.setDate(int arg0, java.sql.Date arg1, java.util.Calendar arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_._setDate24555, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._setDate24555, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setDate24556;
		 void java.sql.PreparedStatement.setDate(int arg0, java.sql.Date arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_._setDate24556, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._setDate24556, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _execute24557;
		 bool java.sql.PreparedStatement.execute() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.PreparedStatement_._execute24557);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._execute24557);
		}
		internal static global::MonoJavaBridge.MethodId _addBatch24558;
		 void java.sql.PreparedStatement.addBatch() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_._addBatch24558);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._addBatch24558);
		}
		internal static global::MonoJavaBridge.MethodId _setString24559;
		 void java.sql.PreparedStatement.setString(int arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_._setString24559, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._setString24559, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setObject24560;
		 void java.sql.PreparedStatement.setObject(int arg0, java.lang.Object arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_._setObject24560, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._setObject24560, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setObject24561;
		 void java.sql.PreparedStatement.setObject(int arg0, java.lang.Object arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_._setObject24561, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._setObject24561, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _setObject24562;
		 void java.sql.PreparedStatement.setObject(int arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_._setObject24562, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._setObject24562, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getMetaData24563;
		 global::java.sql.ResultSetMetaData java.sql.PreparedStatement.getMetaData() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSetMetaData>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.PreparedStatement_._getMetaData24563)) as java.sql.ResultSetMetaData;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSetMetaData>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._getMetaData24563)) as java.sql.ResultSetMetaData;
		}
		internal static global::MonoJavaBridge.MethodId _setBytes24564;
		 void java.sql.PreparedStatement.setBytes(int arg0, byte[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_._setBytes24564, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._setBytes24564, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setBinaryStream24565;
		 void java.sql.PreparedStatement.setBinaryStream(int arg0, java.io.InputStream arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_._setBinaryStream24565, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._setBinaryStream24565, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setBinaryStream24566;
		 void java.sql.PreparedStatement.setBinaryStream(int arg0, java.io.InputStream arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_._setBinaryStream24566, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._setBinaryStream24566, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setBinaryStream24567;
		 void java.sql.PreparedStatement.setBinaryStream(int arg0, java.io.InputStream arg1, long arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_._setBinaryStream24567, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._setBinaryStream24567, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setNull24568;
		 void java.sql.PreparedStatement.setNull(int arg0, int arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_._setNull24568, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._setNull24568, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setNull24569;
		 void java.sql.PreparedStatement.setNull(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_._setNull24569, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._setNull24569, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setBigDecimal24570;
		 void java.sql.PreparedStatement.setBigDecimal(int arg0, java.math.BigDecimal arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_._setBigDecimal24570, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._setBigDecimal24570, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setAsciiStream24571;
		 void java.sql.PreparedStatement.setAsciiStream(int arg0, java.io.InputStream arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_._setAsciiStream24571, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._setAsciiStream24571, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setAsciiStream24572;
		 void java.sql.PreparedStatement.setAsciiStream(int arg0, java.io.InputStream arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_._setAsciiStream24572, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._setAsciiStream24572, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setAsciiStream24573;
		 void java.sql.PreparedStatement.setAsciiStream(int arg0, java.io.InputStream arg1, long arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_._setAsciiStream24573, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._setAsciiStream24573, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setCharacterStream24574;
		 void java.sql.PreparedStatement.setCharacterStream(int arg0, java.io.Reader arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_._setCharacterStream24574, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._setCharacterStream24574, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setCharacterStream24575;
		 void java.sql.PreparedStatement.setCharacterStream(int arg0, java.io.Reader arg1, long arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_._setCharacterStream24575, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._setCharacterStream24575, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setCharacterStream24576;
		 void java.sql.PreparedStatement.setCharacterStream(int arg0, java.io.Reader arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_._setCharacterStream24576, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._setCharacterStream24576, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setNString24577;
		 void java.sql.PreparedStatement.setNString(int arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_._setNString24577, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._setNString24577, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setNCharacterStream24578;
		 void java.sql.PreparedStatement.setNCharacterStream(int arg0, java.io.Reader arg1, long arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_._setNCharacterStream24578, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._setNCharacterStream24578, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setNCharacterStream24579;
		 void java.sql.PreparedStatement.setNCharacterStream(int arg0, java.io.Reader arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_._setNCharacterStream24579, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._setNCharacterStream24579, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setNClob24580;
		 void java.sql.PreparedStatement.setNClob(int arg0, java.io.Reader arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_._setNClob24580, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._setNClob24580, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setNClob24581;
		 void java.sql.PreparedStatement.setNClob(int arg0, java.io.Reader arg1, long arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_._setNClob24581, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._setNClob24581, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setClob24582;
		 void java.sql.PreparedStatement.setClob(int arg0, java.sql.Clob arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_._setClob24582, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._setClob24582, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setClob24583;
		 void java.sql.PreparedStatement.setClob(int arg0, java.io.Reader arg1, long arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_._setClob24583, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._setClob24583, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setClob24584;
		 void java.sql.PreparedStatement.setClob(int arg0, java.io.Reader arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_._setClob24584, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._setClob24584, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setBlob24585;
		 void java.sql.PreparedStatement.setBlob(int arg0, java.sql.Blob arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_._setBlob24585, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._setBlob24585, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setBlob24586;
		 void java.sql.PreparedStatement.setBlob(int arg0, java.io.InputStream arg1, long arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_._setBlob24586, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._setBlob24586, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setBlob24587;
		 void java.sql.PreparedStatement.setBlob(int arg0, java.io.InputStream arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_._setBlob24587, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._setBlob24587, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _executeQuery24588;
		 global::java.sql.ResultSet java.sql.PreparedStatement.executeQuery() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.PreparedStatement_._executeQuery24588)) as java.sql.ResultSet;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._executeQuery24588)) as java.sql.ResultSet;
		}
		internal static global::MonoJavaBridge.MethodId _executeUpdate24589;
		 int java.sql.PreparedStatement.executeUpdate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.PreparedStatement_._executeUpdate24589);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._executeUpdate24589);
		}
		internal static global::MonoJavaBridge.MethodId _setUnicodeStream24590;
		 void java.sql.PreparedStatement.setUnicodeStream(int arg0, java.io.InputStream arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_._setUnicodeStream24590, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._setUnicodeStream24590, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _clearParameters24591;
		 void java.sql.PreparedStatement.clearParameters() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_._clearParameters24591);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._clearParameters24591);
		}
		internal static global::MonoJavaBridge.MethodId _setRef24592;
		 void java.sql.PreparedStatement.setRef(int arg0, java.sql.Ref arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_._setRef24592, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._setRef24592, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setArray24593;
		 void java.sql.PreparedStatement.setArray(int arg0, java.sql.Array arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_._setArray24593, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._setArray24593, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getParameterMetaData24594;
		 global::java.sql.ParameterMetaData java.sql.PreparedStatement.getParameterMetaData() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ParameterMetaData>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.PreparedStatement_._getParameterMetaData24594)) as java.sql.ParameterMetaData;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ParameterMetaData>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._getParameterMetaData24594)) as java.sql.ParameterMetaData;
		}
		internal static global::MonoJavaBridge.MethodId _close24595;
		 void java.sql.Statement.close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_._close24595);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._close24595);
		}
		internal static global::MonoJavaBridge.MethodId _isClosed24596;
		 bool java.sql.Statement.isClosed() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.PreparedStatement_._isClosed24596);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._isClosed24596);
		}
		internal static global::MonoJavaBridge.MethodId _execute24597;
		 bool java.sql.Statement.execute(java.lang.String arg0, int[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.PreparedStatement_._execute24597, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._execute24597, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _execute24598;
		 bool java.sql.Statement.execute(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.PreparedStatement_._execute24598, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._execute24598, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _execute24599;
		 bool java.sql.Statement.execute(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.PreparedStatement_._execute24599, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._execute24599, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _execute24600;
		 bool java.sql.Statement.execute(java.lang.String arg0, java.lang.String[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.PreparedStatement_._execute24600, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._execute24600, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _cancel24601;
		 void java.sql.Statement.cancel() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_._cancel24601);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._cancel24601);
		}
		internal static global::MonoJavaBridge.MethodId _addBatch24602;
		 void java.sql.Statement.addBatch(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_._addBatch24602, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._addBatch24602, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getConnection24603;
		 global::java.sql.Connection java.sql.Statement.getConnection() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Connection>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.PreparedStatement_._getConnection24603)) as java.sql.Connection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Connection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._getConnection24603)) as java.sql.Connection;
		}
		internal static global::MonoJavaBridge.MethodId _getResultSet24604;
		 global::java.sql.ResultSet java.sql.Statement.getResultSet() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.PreparedStatement_._getResultSet24604)) as java.sql.ResultSet;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._getResultSet24604)) as java.sql.ResultSet;
		}
		internal static global::MonoJavaBridge.MethodId _getWarnings24605;
		 global::java.sql.SQLWarning java.sql.Statement.getWarnings() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.PreparedStatement_._getWarnings24605)) as java.sql.SQLWarning;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._getWarnings24605)) as java.sql.SQLWarning;
		}
		internal static global::MonoJavaBridge.MethodId _clearWarnings24606;
		 void java.sql.Statement.clearWarnings() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_._clearWarnings24606);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._clearWarnings24606);
		}
		internal static global::MonoJavaBridge.MethodId _setFetchDirection24607;
		 void java.sql.Statement.setFetchDirection(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_._setFetchDirection24607, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._setFetchDirection24607, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFetchDirection24608;
		 int java.sql.Statement.getFetchDirection() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.PreparedStatement_._getFetchDirection24608);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._getFetchDirection24608);
		}
		internal static global::MonoJavaBridge.MethodId _setFetchSize24609;
		 void java.sql.Statement.setFetchSize(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_._setFetchSize24609, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._setFetchSize24609, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFetchSize24610;
		 int java.sql.Statement.getFetchSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.PreparedStatement_._getFetchSize24610);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._getFetchSize24610);
		}
		internal static global::MonoJavaBridge.MethodId _executeQuery24611;
		 global::java.sql.ResultSet java.sql.Statement.executeQuery(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.PreparedStatement_._executeQuery24611, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.ResultSet;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._executeQuery24611, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.ResultSet;
		}
		internal static global::MonoJavaBridge.MethodId _executeUpdate24612;
		 int java.sql.Statement.executeUpdate(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.PreparedStatement_._executeUpdate24612, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._executeUpdate24612, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _executeUpdate24613;
		 int java.sql.Statement.executeUpdate(java.lang.String arg0, int[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.PreparedStatement_._executeUpdate24613, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._executeUpdate24613, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _executeUpdate24614;
		 int java.sql.Statement.executeUpdate(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.PreparedStatement_._executeUpdate24614, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._executeUpdate24614, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _executeUpdate24615;
		 int java.sql.Statement.executeUpdate(java.lang.String arg0, java.lang.String[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.PreparedStatement_._executeUpdate24615, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._executeUpdate24615, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getMaxFieldSize24616;
		 int java.sql.Statement.getMaxFieldSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.PreparedStatement_._getMaxFieldSize24616);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._getMaxFieldSize24616);
		}
		internal static global::MonoJavaBridge.MethodId _setMaxFieldSize24617;
		 void java.sql.Statement.setMaxFieldSize(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_._setMaxFieldSize24617, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._setMaxFieldSize24617, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getMaxRows24618;
		 int java.sql.Statement.getMaxRows() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.PreparedStatement_._getMaxRows24618);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._getMaxRows24618);
		}
		internal static global::MonoJavaBridge.MethodId _setMaxRows24619;
		 void java.sql.Statement.setMaxRows(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_._setMaxRows24619, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._setMaxRows24619, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setEscapeProcessing24620;
		 void java.sql.Statement.setEscapeProcessing(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_._setEscapeProcessing24620, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._setEscapeProcessing24620, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getQueryTimeout24621;
		 int java.sql.Statement.getQueryTimeout() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.PreparedStatement_._getQueryTimeout24621);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._getQueryTimeout24621);
		}
		internal static global::MonoJavaBridge.MethodId _setQueryTimeout24622;
		 void java.sql.Statement.setQueryTimeout(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_._setQueryTimeout24622, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._setQueryTimeout24622, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setCursorName24623;
		 void java.sql.Statement.setCursorName(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_._setCursorName24623, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._setCursorName24623, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getUpdateCount24624;
		 int java.sql.Statement.getUpdateCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.PreparedStatement_._getUpdateCount24624);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._getUpdateCount24624);
		}
		internal static global::MonoJavaBridge.MethodId _getMoreResults24625;
		 bool java.sql.Statement.getMoreResults() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.PreparedStatement_._getMoreResults24625);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._getMoreResults24625);
		}
		internal static global::MonoJavaBridge.MethodId _getMoreResults24626;
		 bool java.sql.Statement.getMoreResults(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.PreparedStatement_._getMoreResults24626, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._getMoreResults24626, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getResultSetConcurrency24627;
		 int java.sql.Statement.getResultSetConcurrency() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.PreparedStatement_._getResultSetConcurrency24627);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._getResultSetConcurrency24627);
		}
		internal static global::MonoJavaBridge.MethodId _getResultSetType24628;
		 int java.sql.Statement.getResultSetType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.PreparedStatement_._getResultSetType24628);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._getResultSetType24628);
		}
		internal static global::MonoJavaBridge.MethodId _clearBatch24629;
		 void java.sql.Statement.clearBatch() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_._clearBatch24629);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._clearBatch24629);
		}
		internal static global::MonoJavaBridge.MethodId _executeBatch24630;
		 int[] java.sql.Statement.executeBatch() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.PreparedStatement_._executeBatch24630)) as int[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._executeBatch24630)) as int[];
		}
		internal static global::MonoJavaBridge.MethodId _getGeneratedKeys24631;
		 global::java.sql.ResultSet java.sql.Statement.getGeneratedKeys() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.PreparedStatement_._getGeneratedKeys24631)) as java.sql.ResultSet;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._getGeneratedKeys24631)) as java.sql.ResultSet;
		}
		internal static global::MonoJavaBridge.MethodId _getResultSetHoldability24632;
		 int java.sql.Statement.getResultSetHoldability() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.PreparedStatement_._getResultSetHoldability24632);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._getResultSetHoldability24632);
		}
		internal static global::MonoJavaBridge.MethodId _setPoolable24633;
		 void java.sql.Statement.setPoolable(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_._setPoolable24633, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._setPoolable24633, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isPoolable24634;
		 bool java.sql.Statement.isPoolable() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.PreparedStatement_._isPoolable24634);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._isPoolable24634);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.sql.PreparedStatement_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/sql/PreparedStatement"));
			global::java.sql.PreparedStatement_._setBoolean24543 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "setBoolean", "(IZ)V");
			global::java.sql.PreparedStatement_._setByte24544 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "setByte", "(IB)V");
			global::java.sql.PreparedStatement_._setShort24545 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "setShort", "(IS)V");
			global::java.sql.PreparedStatement_._setInt24546 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "setInt", "(II)V");
			global::java.sql.PreparedStatement_._setLong24547 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "setLong", "(IJ)V");
			global::java.sql.PreparedStatement_._setFloat24548 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "setFloat", "(IF)V");
			global::java.sql.PreparedStatement_._setDouble24549 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "setDouble", "(ID)V");
			global::java.sql.PreparedStatement_._setTimestamp24550 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "setTimestamp", "(ILjava/sql/Timestamp;)V");
			global::java.sql.PreparedStatement_._setTimestamp24551 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "setTimestamp", "(ILjava/sql/Timestamp;Ljava/util/Calendar;)V");
			global::java.sql.PreparedStatement_._setURL24552 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "setURL", "(ILjava/net/URL;)V");
			global::java.sql.PreparedStatement_._setTime24553 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "setTime", "(ILjava/sql/Time;Ljava/util/Calendar;)V");
			global::java.sql.PreparedStatement_._setTime24554 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "setTime", "(ILjava/sql/Time;)V");
			global::java.sql.PreparedStatement_._setDate24555 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "setDate", "(ILjava/sql/Date;Ljava/util/Calendar;)V");
			global::java.sql.PreparedStatement_._setDate24556 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "setDate", "(ILjava/sql/Date;)V");
			global::java.sql.PreparedStatement_._execute24557 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "execute", "()Z");
			global::java.sql.PreparedStatement_._addBatch24558 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "addBatch", "()V");
			global::java.sql.PreparedStatement_._setString24559 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "setString", "(ILjava/lang/String;)V");
			global::java.sql.PreparedStatement_._setObject24560 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "setObject", "(ILjava/lang/Object;I)V");
			global::java.sql.PreparedStatement_._setObject24561 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "setObject", "(ILjava/lang/Object;II)V");
			global::java.sql.PreparedStatement_._setObject24562 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "setObject", "(ILjava/lang/Object;)V");
			global::java.sql.PreparedStatement_._getMetaData24563 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "getMetaData", "()Ljava/sql/ResultSetMetaData;");
			global::java.sql.PreparedStatement_._setBytes24564 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "setBytes", "(I[B)V");
			global::java.sql.PreparedStatement_._setBinaryStream24565 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "setBinaryStream", "(ILjava/io/InputStream;)V");
			global::java.sql.PreparedStatement_._setBinaryStream24566 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "setBinaryStream", "(ILjava/io/InputStream;I)V");
			global::java.sql.PreparedStatement_._setBinaryStream24567 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "setBinaryStream", "(ILjava/io/InputStream;J)V");
			global::java.sql.PreparedStatement_._setNull24568 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "setNull", "(IILjava/lang/String;)V");
			global::java.sql.PreparedStatement_._setNull24569 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "setNull", "(II)V");
			global::java.sql.PreparedStatement_._setBigDecimal24570 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "setBigDecimal", "(ILjava/math/BigDecimal;)V");
			global::java.sql.PreparedStatement_._setAsciiStream24571 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "setAsciiStream", "(ILjava/io/InputStream;I)V");
			global::java.sql.PreparedStatement_._setAsciiStream24572 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "setAsciiStream", "(ILjava/io/InputStream;)V");
			global::java.sql.PreparedStatement_._setAsciiStream24573 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "setAsciiStream", "(ILjava/io/InputStream;J)V");
			global::java.sql.PreparedStatement_._setCharacterStream24574 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "setCharacterStream", "(ILjava/io/Reader;I)V");
			global::java.sql.PreparedStatement_._setCharacterStream24575 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "setCharacterStream", "(ILjava/io/Reader;J)V");
			global::java.sql.PreparedStatement_._setCharacterStream24576 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "setCharacterStream", "(ILjava/io/Reader;)V");
			global::java.sql.PreparedStatement_._setNString24577 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "setNString", "(ILjava/lang/String;)V");
			global::java.sql.PreparedStatement_._setNCharacterStream24578 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "setNCharacterStream", "(ILjava/io/Reader;J)V");
			global::java.sql.PreparedStatement_._setNCharacterStream24579 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "setNCharacterStream", "(ILjava/io/Reader;)V");
			global::java.sql.PreparedStatement_._setNClob24580 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "setNClob", "(ILjava/io/Reader;)V");
			global::java.sql.PreparedStatement_._setNClob24581 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "setNClob", "(ILjava/io/Reader;J)V");
			global::java.sql.PreparedStatement_._setClob24582 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "setClob", "(ILjava/sql/Clob;)V");
			global::java.sql.PreparedStatement_._setClob24583 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "setClob", "(ILjava/io/Reader;J)V");
			global::java.sql.PreparedStatement_._setClob24584 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "setClob", "(ILjava/io/Reader;)V");
			global::java.sql.PreparedStatement_._setBlob24585 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "setBlob", "(ILjava/sql/Blob;)V");
			global::java.sql.PreparedStatement_._setBlob24586 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "setBlob", "(ILjava/io/InputStream;J)V");
			global::java.sql.PreparedStatement_._setBlob24587 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "setBlob", "(ILjava/io/InputStream;)V");
			global::java.sql.PreparedStatement_._executeQuery24588 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "executeQuery", "()Ljava/sql/ResultSet;");
			global::java.sql.PreparedStatement_._executeUpdate24589 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "executeUpdate", "()I");
			global::java.sql.PreparedStatement_._setUnicodeStream24590 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "setUnicodeStream", "(ILjava/io/InputStream;I)V");
			global::java.sql.PreparedStatement_._clearParameters24591 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "clearParameters", "()V");
			global::java.sql.PreparedStatement_._setRef24592 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "setRef", "(ILjava/sql/Ref;)V");
			global::java.sql.PreparedStatement_._setArray24593 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "setArray", "(ILjava/sql/Array;)V");
			global::java.sql.PreparedStatement_._getParameterMetaData24594 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "getParameterMetaData", "()Ljava/sql/ParameterMetaData;");
			global::java.sql.PreparedStatement_._close24595 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "close", "()V");
			global::java.sql.PreparedStatement_._isClosed24596 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "isClosed", "()Z");
			global::java.sql.PreparedStatement_._execute24597 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "execute", "(Ljava/lang/String;[I)Z");
			global::java.sql.PreparedStatement_._execute24598 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "execute", "(Ljava/lang/String;I)Z");
			global::java.sql.PreparedStatement_._execute24599 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "execute", "(Ljava/lang/String;)Z");
			global::java.sql.PreparedStatement_._execute24600 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "execute", "(Ljava/lang/String;[Ljava/lang/String;)Z");
			global::java.sql.PreparedStatement_._cancel24601 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "cancel", "()V");
			global::java.sql.PreparedStatement_._addBatch24602 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "addBatch", "(Ljava/lang/String;)V");
			global::java.sql.PreparedStatement_._getConnection24603 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "getConnection", "()Ljava/sql/Connection;");
			global::java.sql.PreparedStatement_._getResultSet24604 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "getResultSet", "()Ljava/sql/ResultSet;");
			global::java.sql.PreparedStatement_._getWarnings24605 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "getWarnings", "()Ljava/sql/SQLWarning;");
			global::java.sql.PreparedStatement_._clearWarnings24606 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "clearWarnings", "()V");
			global::java.sql.PreparedStatement_._setFetchDirection24607 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "setFetchDirection", "(I)V");
			global::java.sql.PreparedStatement_._getFetchDirection24608 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "getFetchDirection", "()I");
			global::java.sql.PreparedStatement_._setFetchSize24609 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "setFetchSize", "(I)V");
			global::java.sql.PreparedStatement_._getFetchSize24610 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "getFetchSize", "()I");
			global::java.sql.PreparedStatement_._executeQuery24611 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "executeQuery", "(Ljava/lang/String;)Ljava/sql/ResultSet;");
			global::java.sql.PreparedStatement_._executeUpdate24612 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "executeUpdate", "(Ljava/lang/String;I)I");
			global::java.sql.PreparedStatement_._executeUpdate24613 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "executeUpdate", "(Ljava/lang/String;[I)I");
			global::java.sql.PreparedStatement_._executeUpdate24614 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "executeUpdate", "(Ljava/lang/String;)I");
			global::java.sql.PreparedStatement_._executeUpdate24615 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "executeUpdate", "(Ljava/lang/String;[Ljava/lang/String;)I");
			global::java.sql.PreparedStatement_._getMaxFieldSize24616 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "getMaxFieldSize", "()I");
			global::java.sql.PreparedStatement_._setMaxFieldSize24617 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "setMaxFieldSize", "(I)V");
			global::java.sql.PreparedStatement_._getMaxRows24618 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "getMaxRows", "()I");
			global::java.sql.PreparedStatement_._setMaxRows24619 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "setMaxRows", "(I)V");
			global::java.sql.PreparedStatement_._setEscapeProcessing24620 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "setEscapeProcessing", "(Z)V");
			global::java.sql.PreparedStatement_._getQueryTimeout24621 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "getQueryTimeout", "()I");
			global::java.sql.PreparedStatement_._setQueryTimeout24622 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "setQueryTimeout", "(I)V");
			global::java.sql.PreparedStatement_._setCursorName24623 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "setCursorName", "(Ljava/lang/String;)V");
			global::java.sql.PreparedStatement_._getUpdateCount24624 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "getUpdateCount", "()I");
			global::java.sql.PreparedStatement_._getMoreResults24625 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "getMoreResults", "()Z");
			global::java.sql.PreparedStatement_._getMoreResults24626 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "getMoreResults", "(I)Z");
			global::java.sql.PreparedStatement_._getResultSetConcurrency24627 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "getResultSetConcurrency", "()I");
			global::java.sql.PreparedStatement_._getResultSetType24628 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "getResultSetType", "()I");
			global::java.sql.PreparedStatement_._clearBatch24629 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "clearBatch", "()V");
			global::java.sql.PreparedStatement_._executeBatch24630 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "executeBatch", "()[I");
			global::java.sql.PreparedStatement_._getGeneratedKeys24631 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "getGeneratedKeys", "()Ljava/sql/ResultSet;");
			global::java.sql.PreparedStatement_._getResultSetHoldability24632 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "getResultSetHoldability", "()I");
			global::java.sql.PreparedStatement_._setPoolable24633 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "setPoolable", "(Z)V");
			global::java.sql.PreparedStatement_._isPoolable24634 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "isPoolable", "()Z");
		}
	}
}
